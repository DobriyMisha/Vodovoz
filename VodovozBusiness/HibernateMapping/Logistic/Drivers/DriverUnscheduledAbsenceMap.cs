using FluentNHibernate.Mapping;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.HibernateMapping.Logistic.Drivers
{
    public class DriverUnscheduledAbsenceMap : ClassMap<DriverUnscheduledAbsence>
    {
        public DriverUnscheduledAbsenceMap()
        {
            Table("driver_unscheduled_absences");

            Id(x => x.Id).Column("id").GeneratedBy.Native();

            Map(x => x.DateTime).Column("date_time");
            Map(x => x.UnscheduledAbsenceReason).Column("reason").CustomType<UnscheduledAbsenceReasonStringType>();
            Map(x => x.Comment).Column("comment");
        }
    }
}
