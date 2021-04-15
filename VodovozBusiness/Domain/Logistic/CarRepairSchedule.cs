using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QS.DomainModel.Entity;
using QS.HistoryLog;

namespace Vodovoz.Domain.Logistic
{
    [Appellative(Gender = GrammaticalGender.Masculine,
        Nominative = "График ремонта автомобиля",
        NominativePlural = "График ремонтов автомобиля"
    )]
    [HistoryTrace]
    public class CarRepairSchedule : PropertyChangedBase, IDomainObject, IValidatableObject
    {
        public virtual int Id { get; set; }

        private Car car;
        [Display(Name = "Автомобиль")]
        public virtual Car Car {
            get => car;
            set => SetField(ref car, value);
        }

        private string comment;
        [Display(Name = "Комментарий")]
        public virtual string Comment {
            get => comment;
            set => SetField(ref comment, value);
        }

        private DateTime startDate;
        [Display(Name = "Начальная дата")]
        public virtual DateTime StartDate {
            get => startDate;
            set => SetField(ref startDate, value);
        }

        private DateTime endDate;
        [Display(Name = "Конечная дата")]
        public virtual DateTime EndDate {
            get => endDate;
            set => SetField(ref endDate, value);
        }

        private BreakdownKind breakdownKind;
        [Display(Name = "Вид поломки")]
        public virtual BreakdownKind BreakdownKind {
            get => breakdownKind;
            set => SetField(ref breakdownKind, value);
        }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Comment?.Length > 255) {
                yield return new ValidationResult(
                    "Длина комментария не должна превышать 255 символов",
                    new[] { nameof(Comment) });
            }

            if(Car == null) {
                yield return new ValidationResult(
                    "Должен быть заполнен автомобиль",
                    new[] { nameof(Car) });
            }

            if(StartDate > EndDate) {
                yield return new ValidationResult(
                    "Начальная дата должна быть меньше или равна конечной дате",
                    new[] { nameof(StartDate), nameof(EndDate) });
            }

            validationContext.Items.TryGetValue("ExcludeScheduleValidation", out var excludeSchedule);

            if(Car != null && Car.ObservableCarRepairSchedules.Any(x => StartDate <= x.EndDate && EndDate >= x.StartDate
                && (!(excludeSchedule is CarRepairSchedule) || !x.Equals(excludeSchedule))
            )) {
                yield return new ValidationResult(
                    "Выбранный период пересекается с другом периодом графика ремонта",
                    new[] { nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}
