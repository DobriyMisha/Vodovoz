using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QS.DomainModel.Entity;
using QS.DomainModel.Entity.EntityPermissions;
using QS.HistoryLog;
using Vodovoz.Data;
using Vodovoz.Domain.Employees;

namespace Vodovoz.Domain.Logistic
{
    [Appellative(Gender = GrammaticalGender.Masculine,
        Nominative = "Привязанный водитель",
        NominativePlural = "Привязанные водители"
    )]
    [HistoryTrace]
    [EntityPermission]
    public class AssignedDriver : PropertyChangedBase, IDomainObject, IValidatableObject
    {
        public virtual int Id { get; set; }

        private Car car;
        [Display(Name = "Автомобиль")]
        public virtual Car Car {
            get => car;
            set => SetField(ref car, value);
        }

        private Employee driver;
        [Display(Name = "Водитель")]
        public virtual Employee Driver {
            get => driver;
            set => SetField(ref driver, value);
        }

        private DateTime startDate;
        [Display(Name = "Начальная дата")]
        public virtual DateTime StartDate {
            get => startDate;
            set => SetField(ref startDate, value);
        }

        private DateTime? endDate;
        [Display(Name = "Конечная дата")]
        public virtual DateTime? EndDate {
            get => endDate;
            set => SetField(ref endDate, value);
        }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!validationContext.Items.TryGetValue("DatePeriodOverlapValidationList", out var validationListObj)
                || !(validationListObj is IEnumerable<DatePeriod> datePeriods)
            ) {
                throw new ArgumentException("Не верно передан ValidationContext");
            }

            if(Car == null) {
                yield return new ValidationResult("Должен быть заполнен автомобиль",
                    new[] { nameof(Car) });
            }

            if(Driver == null) {
                yield return new ValidationResult("Должен быть заполнен водитель",
                    new[] { nameof(Driver) });
            }

            if(StartDate > EndDate) {
                yield return new ValidationResult("Начальная дата должна быть меньше или равна конечной дате",
                    new[] { nameof(StartDate), nameof(EndDate) });
            }

            if(datePeriods.Any(x => StartDate <= x.EndDate && EndDate >= x.StartDate)) {
                yield return new ValidationResult(
                    "Выбранный период пересекается с другом периодом привязанного водителя",
                    new[] { nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}
