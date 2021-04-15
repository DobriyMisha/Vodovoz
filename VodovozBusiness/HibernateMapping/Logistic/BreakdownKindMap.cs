using FluentNHibernate.Mapping;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.HibernateMapping.Logistic
{
    public class BreakdownKindMap : ClassMap<BreakdownKind>
    {
        public BreakdownKindMap()
        {
            Table("breakdown_kinds");

            Id(x => x.Id).Column("id").GeneratedBy.Native();

            Map(x => x.IsArchive).Column("is_archive");
            Map(x => x.Name).Column("name");
        }
    }
}
