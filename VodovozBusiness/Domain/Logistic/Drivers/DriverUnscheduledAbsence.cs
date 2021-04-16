using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;
using Vodovoz.Domain.Employees;

namespace Vodovoz.Domain.Logistic
{
    [Appellative(Gender = GrammaticalGender.Masculine,
        Nominative = "внеплановый выход из графика",
        NominativePlural = "внеплановые выходы из графика")]
    public class DriverUnscheduledAbsence : PropertyChangedBase, IDomainObject, IValidatableObject
    {
        public virtual int Id { get; set; }

        private DateTime dateTime;
        [Display(Name = "Дата")]
        public virtual DateTime DateTime {
            get => dateTime;
            set => SetField(ref dateTime, value);
        }

        private string comment;
        [Display(Name = "Комментарий")]
        public virtual string Comment {
            get => comment;
            set => SetField(ref comment, value);
        }

        private UnscheduledAbsenceReason unscheduledAbsenceReason;
        [Display(Name = "Причина")]
        public virtual UnscheduledAbsenceReason UnscheduledAbsenceReason {
            get => unscheduledAbsenceReason;
            set => SetField(ref unscheduledAbsenceReason, value);
        }
        
        private Employee driver;
        [Display(Name = "Водитель")]
        public virtual Employee Driver {
            get => driver;
            set => SetField(ref driver, value);
        }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Comment?.Length > 255) {
                yield return new ValidationResult(
                    "Длина комментария не должна превышать 255 символов",
                    new[] { nameof(Comment) });
            }

            if(Driver == null) {
                yield return new ValidationResult(
                    "Должен быть заполнен водитель",
                    new[] { nameof(Car) });
            }

            // validationContext.Items.TryGetValue("ExcludeScheduleValidation", out var excludeSchedule);
            // if(Driver != null && Car.ObservableCarRepairSchedules.Any(x => StartDate <= x.EndDate && EndDate >= x.StartDate
            //     && (!(excludeSchedule is CarRepairSchedule) || !x.Equals(excludeSchedule))
            // )) {
            //     yield return new ValidationResult(
            //         "Выбранный период пересекается с другом периодом графика ремонта",
            //         new[] { nameof(StartDate), nameof(EndDate) });
            // }
        }
    }

    public enum UnscheduledAbsenceReason
    {
        [Display(Name = "Внеплановый выходной")]
        UnscheduledDayOff,
        [Display(Name = "Болезнь")]
        Sickness
    }

    public class UnscheduledAbsenceReasonStringType : NHibernate.Type.EnumStringType
    {
        public UnscheduledAbsenceReasonStringType() : base(typeof(UnscheduledAbsenceReason)) { }
    }
}
