using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;

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

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
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
