using FluentNHibernate.Mapping;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.HibernateMapping.Logistic.Drivers
{
    public class DriverUncheduledAbsenceMap : ClassMap<DriverUncheduledAbsence>
    {
        public DriverUncheduledAbsenceMap()
        {
            Table("driver_uncheduled_absences");

            Id(x => x.Id).Column("id").GeneratedBy.Native();

            Map(x => x.DateTime).Column("date_time");
            Map(x => x.UncheduledAbsenceReason).Column("reason").CustomType<UncheduledAbsenceReasonStringType>();
            Map(x => x.Comment).Column("comment");
        }
    }
}
