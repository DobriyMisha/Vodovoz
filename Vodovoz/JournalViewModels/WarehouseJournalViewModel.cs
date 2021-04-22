﻿using System;
using System.Linq;
using NHibernate;
using NHibernate.Transform;
using QS.DomainModel.UoW;
using QS.Project.Domain;
using QS.Project.Journal;
using QS.Services;
using Vodovoz.Additions.Store;
using Vodovoz.Domain.Store;
using Vodovoz.Infrastructure.Permissions;
using Vodovoz.ViewModels.Journals.JournalNodes;
using Vodovoz.ViewModels.Warehouses;

namespace Vodovoz.JournalViewModels
{
    public class WarehouseJournalViewModel
        : SingleEntityJournalViewModelBase<Warehouse, WarehouseViewModel, WarehouseJournalNode>
    {
        public WarehouseJournalViewModel(
            IUnitOfWorkFactory unitOfWorkFactory,
            ICommonServices commonServices)
                : base(unitOfWorkFactory, commonServices)
        {
            TabName = "Журнал складов";
            warehousePermissions = new[] { WarehousePermissions.WarehouseView };

            UpdateOnChanges(
                typeof(Warehouse)
            );
        }

        private WarehousePermissions[] warehousePermissions;

        protected override void CreateNodeActions()
        {
            NodeActionsList.Clear();
            CreateDefaultSelectAction();
            CreateDefaultEditAction();
            CreateDefaultAddActions();
        }

        protected override Func<IUnitOfWork, IQueryOver<Warehouse>> ItemsSourceQueryFunction => (uow) => {
            Warehouse warehouseAlias = null;
            WarehouseJournalNode warehouseNodeAlias = null;
            var query = uow.Session.QueryOver<Warehouse>(() => warehouseAlias)
                .WhereRestrictionOn(w => w.Id)
                .IsIn(StoreDocumentHelper.GetRestrictedWarehousesList(UoW, warehousePermissions)
                .Select(wl => wl.Id).ToList());

            query.Where(GetSearchCriterion(
                () => warehouseAlias.Id,
                () => warehouseAlias.Name
            ));
            var result = query.SelectList(list => list
                .Select(w => w.Id).WithAlias(() => warehouseNodeAlias.Id)
                .Select(w => w.Name).WithAlias(() => warehouseNodeAlias.Name)
                )
                .OrderBy(w => w.Name).Asc
                .TransformUsing(Transformers.AliasToBean<WarehouseJournalNode>());
            return result;
        };

        protected override Func<WarehouseViewModel> CreateDialogFunction => () => new WarehouseViewModel(
            EntityUoWBuilder.ForCreate(),
            QS.DomainModel.UoW.UnitOfWorkFactory.GetDefaultFactory,
            commonServices
        );

        protected override Func<WarehouseJournalNode, WarehouseViewModel> OpenDialogFunction => node => new WarehouseViewModel(
            EntityUoWBuilder.ForOpen(node.Id),
            QS.DomainModel.UoW.UnitOfWorkFactory.GetDefaultFactory,
            commonServices
        );
    }
}
