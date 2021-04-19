using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QS.Commands;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Services;
using QS.Validation;
using QS.ViewModels;
using Vodovoz.Data;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.ViewModels.ViewModels.Logistic
{
    public sealed class CarRepairScheduleViewModel : TabViewModelBase
    {
        public CarRepairScheduleViewModel(
            CarRepairSchedule entity,
            IUnitOfWork uow,
            ICommonServices commonServices,
            Car car,
            INavigationManager navigation = null)
            : base(commonServices.InteractiveService, navigation)
        {
            if(uow == null) {
                throw new ArgumentNullException(nameof(uow));
            }
            this.commonServices = commonServices;
            this.car = car ?? throw new ArgumentNullException(nameof(car));

            Entity = entity ?? new CarRepairSchedule();
            InitialEntityFill();

            permissionResult =
                commonServices.CurrentPermissionService.ValidateEntityPermission(typeof(CarRepairSchedule));
            OnPropertyChanged(nameof(CanEdit));

            BreakdownKinds = uow.GetAll<BreakdownKind>();

            EntityToEdit.PropertyChanged += (sender, args) => {
                if(args.PropertyName == nameof(EntityToEdit.Car)) {
                    UpdateTabName();
                }
            };
            UpdateTabName();
        }

        #region Поля и свойства

        private readonly ICommonServices commonServices;
        private readonly Car car;
        private readonly IPermissionResult permissionResult;

        public EventHandler EntityAccepted;
        public CarRepairSchedule Entity { get; }

        private CarRepairSchedule entityToEdit;
        /// <summary>
        /// Временная сущность для редактирования и биндинга,
        /// чтобы получить новую или отредактированную сущность воспользуйтесь свойством <see cref="Entity"/>
        /// </summary>
        public CarRepairSchedule EntityToEdit {
            get => entityToEdit;
            set => SetField(ref entityToEdit, value);
        }

        public IEnumerable<BreakdownKind> BreakdownKinds { get; }

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

            EntityToEdit = new CarRepairSchedule();
            ReplaceDataInCarRepairSchedule(Entity, EntityToEdit);
        }

        private object GetDatePeriodsForOverlapCheck()
        {
            return car.ObservableCarRepairSchedules.Where(x => x != Entity)
                .Select(x => new DatePeriod(x.StartDate, x.EndDate));
        }

        private void UpdateTabName()
        {
            if(Entity.Id == 0) {
                TabName = "Новый график ремонта автомобиля" +
                    (EntityToEdit.Car != null ? $" [{EntityToEdit.Car.RegistrationNumber}]" : "");
            }
            else {
                TabName = "График ремонта автомобиля " +
                    (EntityToEdit.Car != null ? $" [{EntityToEdit.Car.RegistrationNumber}]" : "");
            }
        }

        private void ReplaceDataInCarRepairSchedule(CarRepairSchedule source, CarRepairSchedule destination)
        {
            destination.Car = source.Car;
            destination.Comment = source.Comment;
            destination.BreakdownKind = source.BreakdownKind;
            destination.StartDate = source.StartDate;
            destination.EndDate = source.EndDate;
        }

        #endregion
    }
}
