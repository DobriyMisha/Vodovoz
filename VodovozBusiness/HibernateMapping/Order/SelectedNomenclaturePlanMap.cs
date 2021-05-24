﻿using FluentNHibernate.Mapping;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Orders;

namespace Vodovoz.HibernateMapping.Order
{
    public class SelectedNomenclaturePlanMap : ClassMap<SelectedNomenclaturePlan>
    {
        public SelectedNomenclaturePlanMap()
        {
            Table("selected_nomenclature_plan");
            Id(x => x.Id).Column("id").GeneratedBy.Native();
            References(x => x.Nomenclature).Column("nomenclature_id");
        }
    }
}
