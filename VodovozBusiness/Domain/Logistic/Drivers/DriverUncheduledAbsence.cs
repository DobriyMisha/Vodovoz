using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;

namespace Vodovoz.Domain.Logistic
{
    [Appellative(Gender = GrammaticalGender.Masculine,
        Nominative = "внеплановый выход из графика",
        NominativePlural = "внеплановые выходы из графика")]
    public class DriverUncheduledAbsence : PropertyChangedBase, IDomainObject, IValidatableObject
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

        private UncheduledAbsenceReason uncheduledAbsenceReason;
        [Display(Name = "Причина")]
        public virtual UncheduledAbsenceReason UncheduledAbsenceReason {
            get => uncheduledAbsenceReason;
            set => SetField(ref uncheduledAbsenceReason, value);
        }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }

    public enum UncheduledAbsenceReason
    {
        [Display(Name = "Внеплановый выходной")]
        UncheduleDayOff,
        [Display(Name = "Болезнь")]
        Sickness
    }

    public class UncheduledAbsenceReasonStringType : NHibernate.Type.EnumStringType
    {
        public UncheduledAbsenceReasonStringType() : base(typeof(UncheduledAbsenceReason)) { }
    }
}
