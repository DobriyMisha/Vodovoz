using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;
using QS.HistoryLog;

namespace Vodovoz.Domain.Logistic
{
    [Appellative(Gender = GrammaticalGender.Masculine,
        Nominative = "Вид поломки",
        NominativePlural = "Виды поломки"
    )]
    [HistoryTrace]
    public class BreakdownKind : PropertyChangedBase, IDomainObject, IValidatableObject
    {
        public virtual int Id { get; set; }

        private string name;
        [Display(Name = "Название")]
        public virtual string Name {
            get => name;
            set => SetField(ref name, value);
        }

        private bool isArchive;
        [Display(Name = "Архивный")]
        public virtual bool IsArchive {
            get => isArchive;
            set => SetField(ref isArchive, value);
        }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(String.IsNullOrWhiteSpace(Name)) {
                yield return new ValidationResult(
                    "Укажите название вида поломки",
                    new[] { nameof(Name) });
            }
            if(Name?.Length > 100) {
                yield return new ValidationResult(
                    "Длина названия вида поломки не должна превышать 100 символов",
                    new[] { nameof(Name) });
            }
        }
    }
}
