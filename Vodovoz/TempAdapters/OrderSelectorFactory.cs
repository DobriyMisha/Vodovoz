using System;
using System.Collections.Generic;
using QS.DomainModel.UoW;
using QS.Project.Journal;
using QS.Project.Journal.EntitySelector;
using QS.Project.Services;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.Store;
using Vodovoz.EntityRepositories;
using Vodovoz.EntityRepositories.Goods;
using Vodovoz.Filters.ViewModels;
using Vodovoz.FilterViewModels.Goods;
using Vodovoz.Journals.JournalViewModels;
using Vodovoz.JournalSelector;
using Vodovoz.JournalViewModels;
using Vodovoz.Parameters;

namespace Vodovoz.TempAdapters
{
	public class OrderSelectorFactory : IOrderSelectorFactory
	{
		public IEntitySelector CreateOrderSelectorForDocument(bool IsOnlineStoreOrders, IEnumerable<OrderStatus> orderStatuses)
		{
			OrderForMovDocJournalFilterViewModel orderFilterVM = new OrderForMovDocJournalFilterViewModel();
			orderFilterVM.IsOnlineStoreOrders = IsOnlineStoreOrders;
			orderFilterVM.OrderStatuses = orderStatuses;

			OrderForMovDocJournalViewModel vm = new OrderForMovDocJournalViewModel(
				orderFilterVM,
				UnitOfWorkFactory.GetDefaultFactory,
				ServicesConfig.CommonServices
			) {
				SelectionMode = JournalSelectionMode.Multiple
			};

			return vm;
		}

		public IEntityAutocompleteSelectorFactory GetOrderJournalFactory()
		{
			var nomenclatureRepository = new NomenclatureRepository(new NomenclatureParametersProvider());

			IEntityAutocompleteSelectorFactory counterpartySelectorFactory =
				new DefaultEntityAutocompleteSelectorFactory<Counterparty, CounterpartyJournalViewModel,
					CounterpartyJournalFilterViewModel>(ServicesConfig.CommonServices);

			IEntityAutocompleteSelectorFactory nomenclatureSelectorFactory =
				new NomenclatureAutoCompleteSelectorFactory<Nomenclature, NomenclaturesJournalViewModel>(ServicesConfig.CommonServices,
					new NomenclatureFilterViewModel(), counterpartySelectorFactory, nomenclatureRepository,
					UserSingletonRepository.GetInstance());

			OrderJournalFilterViewModel filter = new OrderJournalFilterViewModel() { IsForRetail = false };

			return new EntityAutocompleteSelectorFactory<OrderJournalViewModel>(typeof(Order), () =>
			{
				return new OrderJournalViewModel(filter,
					UnitOfWorkFactory.GetDefaultFactory,
					ServicesConfig.CommonServices,
					VodovozGtkServicesConfig.EmployeeService,
					nomenclatureSelectorFactory,
					counterpartySelectorFactory,
					nomenclatureRepository,
					UserSingletonRepository.GetInstance());
			});
		}
	}
}
