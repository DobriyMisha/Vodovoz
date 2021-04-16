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

namespace Vodovoz.ViewModels.Logistic
{
    public sealed class DriverUnscheduledAbsenceViewModel : TabViewModelBase
    {
        public DriverUnscheduledAbsenceViewModel(
            DriverUnscheduledAbsence entity,
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

            Entity = entity ?? new DriverUnscheduledAbsence();
            if(Entity.DateTime == default(DateTime)) {
                Entity.DateTime = DateTime.Today;
            }

            EntityToEdit = new DriverUnscheduledAbsence();
            ReplaceDataInDriverUnscheduledAbsence(Entity, EntityToEdit);

            permissionResult = commonServices.CurrentPermissionService.ValidateEntityPermission(typeof(DriverUnscheduledAbsence));
            OnPropertyChanged(nameof(CanEdit));
            
            EntityToEdit.PropertyChanged += (sender, args) => {
                switch(args.PropertyName) {
                    case nameof(EntityToEdit.Driver):
                        UpdateTabName();
                        break;
                }
            };
            UpdateTabName();
        }

        private readonly IValidator validator;
        private readonly IPermissionResult permissionResult;

        public DriverUnscheduledAbsence Entity { get; }

        private DriverUnscheduledAbsence entityToEdit;
        /// <summary>
        /// Временная сущность для редактирования и биндинга,
        /// чтобы получить новую или отредактированную сущность воспользуйтесь свойством <see cref="Entity"/>
        /// </summary>
        public DriverUnscheduledAbsence EntityToEdit {
            get => entityToEdit;
            set => SetField(ref entityToEdit, value);
        }
        
        public EventHandler EntityAccepted;
        public bool CanEdit => (EntityToEdit.Id == 0 && permissionResult.CanCreate) || (EntityToEdit.Id != 0 && permissionResult.CanUpdate);

        #region Команды

        private DelegateCommand acceptCommand;

        public DelegateCommand AcceptCommand => acceptCommand ?? (acceptCommand = new DelegateCommand(
            () => {
                if(!validator.Validate(
                        EntityToEdit,
                        new ValidationContext(
                            EntityToEdit, new Dictionary<object, object> { { "ExcludeAbsenceValidation", Entity } })
                    )
                ) {
                    return;
                }

                ReplaceDataInDriverUnscheduledAbsence(EntityToEdit, Entity);
                Close(false, CloseSource.Self);
                EntityAccepted?.Invoke(this, EventArgs.Empty);
            },
            () => CanEdit
        ));

        #endregion

        private void UpdateTabName()
        {
            if(Entity.Id == 0) {
                TabName = "Новый выход из графика водителя" + (EntityToEdit.Driver != null ? $" [{EntityToEdit.Driver.ShortName}]" : "");
            }
            else {
                TabName = "График ремонта автомобиля " + (EntityToEdit.Driver != null ? $" [{EntityToEdit.Driver.ShortName}]" : "");
            }
        }

        private void ReplaceDataInDriverUnscheduledAbsence(DriverUnscheduledAbsence source, DriverUnscheduledAbsence destination)
        {
            destination.Driver = source.Driver;
            destination.Comment = source.Comment;
            destination.UnscheduledAbsenceReason = source.UnscheduledAbsenceReason;
            destination.DateTime = source.DateTime;
        }
    }
}
