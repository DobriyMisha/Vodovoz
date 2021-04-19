using FluentNHibernate.Mapping;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.HibernateMapping.Logistic
{
    public class AssignedDriverMap : ClassMap<AssignedDriver>
    {
        public AssignedDriverMap()
        {
            Table("assigned_drivers");
            
            Id(x => x.Id).Column("id").GeneratedBy.Native();
            
            Map(x => x.StartDate).Column("start_date");
            Map(x => x.EndDate).Column("end_date");

            References(x => x.Car).Column("car_id");
            References(x => x.Driver).Column("driver_id");
        }
    }
}
