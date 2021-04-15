using FluentNHibernate.Mapping;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.HibernateMapping.Logistic
{
    public class CarRepairScheduleMap : ClassMap<CarRepairSchedule>
    {
        public CarRepairScheduleMap()
        {
            Table("car_breakdown_schedule");

            Id(x => x.Id).Column("id").GeneratedBy.Native();

            Map(x => x.StartDate).Column("start_date");
            Map(x => x.EndDate).Column("end_date");
            Map(x => x.Comment).Column("comment");

            References(x => x.Car).Column("car_id");
            References(x => x.BreakdownKind).Column("breakdown_kind_id");
        }
    }
}
