﻿using System;
using QS.DomainModel.UoW;
using QS.Project.Journal.EntitySelector;
using QS.Project.Services;
using Vodovoz.Domain.Store;
using Vodovoz.JournalViewModels;

namespace Vodovoz.TempAdapters
{
    public class WarehouseSelectorFactory : IEntityAutocompleteSelectorFactory
    {
        public Type EntityType => typeof(Warehouse);

        public IEntityAutocompleteSelector CreateAutocompleteSelector(bool multipleSelect = false)
        {
            var warehouseJournal = new WarehouseJournalViewModel(
                UnitOfWorkFactory.GetDefaultFactory,
                ServicesConfig.CommonServices
            )
            {
                SelectionMode = QS.Project.Journal.JournalSelectionMode.Single
            };
            return warehouseJournal;
        }

        public IEntitySelector CreateSelector(bool multipleSelect = false)
        {
            return CreateAutocompleteSelector(multipleSelect);
        }
    }
}
