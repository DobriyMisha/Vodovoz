using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QS.Commands;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Services;
using QS.Validation;
using QS.ViewModels;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.ViewModels.ViewModels.Logistic
{
    public sealed class CarRepairScheduleViewModel : TabViewModelBase
    {
        public CarRepairScheduleViewModel(
            CarRepairSchedule entity,
            IUnitOfWork uow,
            IValidator validator,
            ICommonServices commonServices,
            INavigationManager navigation = null)
            : base(commonServices.InteractiveService, navigation)
        {
            if(uow == null) {
                throw new ArgumentNullException(nameof(uow));
            }
            this.validator = validator ?? throw new ArgumentNullException(nameof(validator));

            Entity = entity ?? new CarRepairSchedule();
            if(Entity.StartDate == default(DateTime)) {
                Entity.StartDate = DateTime.Today;
            }
            if(Entity.EndDate == default(DateTime)) {
                Entity.EndDate = DateTime.Today;
            }
            EntityToEdit = new CarRepairSchedule();
            ReplaceDataInCarRepairSchedule(Entity, EntityToEdit);

            permissionResult = commonServices.CurrentPermissionService.ValidateEntityPermission(typeof(CarRepairSchedule));
            OnPropertyChanged(nameof(CanEdit));
            
            BreakdownKinds = uow.GetAll<BreakdownKind>();

            EntityToEdit.PropertyChanged += (sender, args) => {
                switch(args.PropertyName) {
                    case nameof(EntityToEdit.Car):
                        UpdateTabName();
                        break;
                }
            };
            UpdateTabName();
        }
        
        private readonly IValidator validator;
        private readonly IPermissionResult permissionResult;
        
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
        
        public EventHandler EntityAccepted;
        public bool CanEdit => (EntityToEdit.Id == 0 && permissionResult.CanCreate) || (EntityToEdit.Id != 0 && permissionResult.CanUpdate);

        #region Команды
        
        private DelegateCommand acceptCommand;
        public DelegateCommand AcceptCommand => acceptCommand ?? (acceptCommand = new DelegateCommand(
            () => {
                if(!validator.Validate(
                    EntityToEdit,
                    new ValidationContext(
                        EntityToEdit, new Dictionary<object, object> { { "ExcludeScheduleValidation", Entity } })
                    )
                ) {
                    return;
                }

                ReplaceDataInCarRepairSchedule(EntityToEdit, Entity);
                Close(false, CloseSource.Self);
                EntityAccepted?.Invoke(this, EventArgs.Empty);
            },
            () => CanEdit
        ));

        #endregion
        
        private void UpdateTabName()
        {
            if(Entity.Id == 0) {
                TabName = "Новый график ремонта автомобиля" + (EntityToEdit.Car != null ? $" [{EntityToEdit.Car.RegistrationNumber}]" : "");
            }
            else {
                TabName = "График ремонта автомобиля " + (EntityToEdit.Car != null ? $" [{EntityToEdit.Car.RegistrationNumber}]" : "");
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
    }
}
