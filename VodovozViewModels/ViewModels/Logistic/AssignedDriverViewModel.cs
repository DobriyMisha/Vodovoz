using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QS.Commands;
using QS.Dialog;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Project.Journal.EntitySelector;
using QS.Services;
using QS.ViewModels;
using Vodovoz.Data;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.ViewModels.ViewModels.Logistic
{
    public sealed class AssignedDriverViewModel : TabViewModelBase, ISingleUoWDialog
    {
        public AssignedDriverViewModel(
            AssignedDriver entity,
            IEntityAutocompleteSelectorFactory entityAutocompleteSelectorFactory,
            Car car,
            IUnitOfWork uow,
            ICommonServices commonServices,
            INavigationManager navigation = null)
            : base(commonServices.InteractiveService, navigation)
        {
            UoW = uow ?? throw new ArgumentNullException(nameof(uow));
            EntityAutocompleteSelectorFactory = entityAutocompleteSelectorFactory
                ?? throw new ArgumentNullException(nameof(entityAutocompleteSelectorFactory));
            this.car = car ?? throw new ArgumentNullException(nameof(car));
            this.commonServices = commonServices;

            Entity = entity ?? new AssignedDriver();
            InitialEntityFill();

            permissionResult =
                commonServices.CurrentPermissionService.ValidateEntityPermission(typeof(CarRepairSchedule));
            OnPropertyChanged(nameof(CanEdit));

            EntityToEdit.PropertyChanged += (sender, args) => {
                if(args.PropertyName == nameof(EntityToEdit.Car) || args.PropertyName == nameof(EntityToEdit.Driver)) {
                    UpdateTabName();
                }
            };
            UpdateTabName();
        }

        #region Поля и свойства

        public readonly IEntityAutocompleteSelectorFactory EntityAutocompleteSelectorFactory;
        private readonly Car car;
        private readonly ICommonServices commonServices;
        private readonly IPermissionResult permissionResult;

        public EventHandler EntityAccepted;
        public AssignedDriver Entity { get; }

        private AssignedDriver entityToEdit;
        /// <summary>
        /// Временная сущность для редактирования и биндинга,
        /// чтобы получить новую или отредактированную сущность воспользуйтесь свойством <see cref="Entity"/>
        /// </summary>
        public AssignedDriver EntityToEdit {
            get => entityToEdit;
            set => SetField(ref entityToEdit, value);
        }

        public bool CanEdit => (EntityToEdit.Id == 0 && permissionResult.CanCreate)
            || (EntityToEdit.Id != 0 && permissionResult.CanUpdate);

        #endregion

        #region Команды

        private DelegateCommand acceptCommand;

        public DelegateCommand AcceptCommand => acceptCommand ?? (acceptCommand = new DelegateCommand(
            () => {
                if(!commonServices.ValidationService.Validate(
                    EntityToEdit,
                    new ValidationContext(
                        EntityToEdit,
                        new Dictionary<object, object>
                            { { "DatePeriodOverlapValidationList", GetDatePeriodsForOverlapCheck() } }))) {
                    return;
                }

                ReplaceDataInCarRepairSchedule(EntityToEdit, Entity);

                Close(false, CloseSource.Self);
                EntityAccepted?.Invoke(this, EventArgs.Empty);
            },
            () => CanEdit
        ));

        #endregion

        #region Приватные методы

        private void InitialEntityFill()
        {
            Entity.Car = car;
            if(Entity.StartDate == default(DateTime)) {
                Entity.StartDate = DateTime.Today;
            }

            if(Entity.EndDate == default(DateTime)) {
                Entity.EndDate = DateTime.Today;
            }

            EntityToEdit = new AssignedDriver();
            ReplaceDataInCarRepairSchedule(Entity, EntityToEdit);
        }

        private object GetDatePeriodsForOverlapCheck()
        {
            return car.ObservableAssignedDrivers.Where(x => x != Entity)
                .Select(x => new DatePeriod(x.StartDate, x.EndDate));
        }

        private void UpdateTabName()
        {
            if(Entity.Id == 0) {
                TabName = "Новый привязанный водитель" +
                    (EntityToEdit.Driver != null ? $" [{EntityToEdit.Driver.ShortName}]" : "") +
                    " к автомобилю" +
                    (EntityToEdit.Car != null ? $" [{EntityToEdit.Car.RegistrationNumber}]" : "");
            }
            else {
                TabName = "Привязанный водитель" +
                    (EntityToEdit.Driver != null ? $" [{EntityToEdit.Driver.ShortName}]" : "") +
                    " к автомобилю" +
                    (EntityToEdit.Car != null ? $" [{EntityToEdit.Car.RegistrationNumber}]" : "");
            }
        }

        private void ReplaceDataInCarRepairSchedule(AssignedDriver source, AssignedDriver destination)
        {
            destination.Car = source.Car;
            destination.Driver = source.Driver;
            destination.StartDate = source.StartDate;
            destination.EndDate = source.EndDate;
        }

        #endregion

        public IUnitOfWork UoW { get; }
    }
}
