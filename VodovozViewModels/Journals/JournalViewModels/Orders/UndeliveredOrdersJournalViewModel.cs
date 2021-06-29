using System;
using System.Collections;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Dialect.Function;
using NHibernate.Transform;
using QS.DomainModel.UoW;
using QS.Project.DB;
using QS.Project.Domain;
using QS.Project.Journal;
using QS.Project.Journal.DataLoader;
using QS.Services;
using Vodovoz.CommonEnums;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Employees;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Logistic;
using Vodovoz.Domain.Orders;
//using Vodovoz.Filters.ViewModels;
using Vodovoz.JournalNodes;
using Vodovoz.Repositories;
using Vodovoz.SidePanel;
using Vodovoz.SidePanel.InfoProviders;
using Vodovoz.ViewModels.Infrastructure.InfoProviders;
using Vodovoz.ViewModels.Journals.FilterViewModels.Orders;
using Vodovoz.ViewModels.Journals.JournalNodes;
using Vodovoz.ViewModels.ViewModels.Orders;

namespace Vodovoz.JournalViewModels
{
	public class UndeliveredOrdersJournalViewModel : FilterableSingleEntityJournalViewModelBase<UndeliveredOrder, UndeliveredOrderViewModel, UndeliveredOrderJournalNode, UndeliveredOrdersFilterViewModel>, IUndeliveredOrdersViewModelInfoProvider
	{
		public UndeliveredOrdersJournalViewModel(UndeliveredOrdersFilterViewModel filterViewModel, IUnitOfWorkFactory unitOfWorkFactory, ICommonServices commonServices) : base(filterViewModel, unitOfWorkFactory, commonServices, true, true)
		{
			TabName = "Журнал недовозов";
			UpdateOnChanges(
				typeof(UndeliveredOrder)
			);
			this.DataLoader.ItemsListUpdated += (sender, e) => CurrentObjectChanged?.Invoke(this, new CurrentObjectChangedArgs(null));
			DataLoader.PostLoadProcessingFunc = BeforeItemsUpdated;

		}
		/*
		protected override Func<IUnitOfWork, IQueryOver<Car>> ItemsSourceQueryFunction => (uow) => {
			CarJournalNode carJournalNodeAlias = null;
			Car carAlias = null;
			Employee driverAlias = null;

			var query = uow.Session.QueryOver<Car>(() => carAlias)
				.Left.JoinAlias(c => c.Driver, () => driverAlias);

			if(FilterViewModel != null) {
				if(!FilterViewModel.IncludeArchive) {
					query.Where(c => !c.IsArchive);
				}

				switch(FilterViewModel.VisitingMasters) {
					case AllYesNo.All:
						break;
					case AllYesNo.Yes:
						query.Where(() => driverAlias.VisitingMaster);
						break;
					case AllYesNo.No:
						query.Where(Restrictions.Disjunction()
							.Add(Restrictions.IsNull(Projections.Property(() => driverAlias.Id)))
							.Add(() => !driverAlias.VisitingMaster));
						break;
				}
				
				switch(FilterViewModel.Raskat) {
					case AllYesNo.All:
						break;
					case AllYesNo.Yes:
						query.Where(() => carAlias.IsRaskat);
						break;
					case AllYesNo.No:
						query.Where(() => !carAlias.IsRaskat);
						break;
				}

				if(FilterViewModel.RestrictedCarTypesOfUse != null) {
					if(!FilterViewModel.RestrictedCarTypesOfUse.Any()) {
						query.Where(Restrictions.IsNull(Projections.Property(() => carAlias.Id)));
					}
					else {
						query.WhereRestrictionOn(c => c.TypeOfUse)
							.IsIn(FilterViewModel.RestrictedCarTypesOfUse.ToArray());
					}
				}
			}

			query.Where(GetSearchCriterion(
				() => carAlias.Id,
				() => carAlias.Model,
				() => carAlias.RegistrationNumber,
				() => driverAlias.Name,
				() => driverAlias.LastName,
				() => driverAlias.Patronymic
			));

			var result = query.SelectList(list => list
			.Select(c => c.Id).WithAlias(() => carJournalNodeAlias.Id)
			.Select(c => c.Model).WithAlias(() => carJournalNodeAlias.Model)
			.Select(c => c.RegistrationNumber).WithAlias(() => carJournalNodeAlias.RegistrationNumber)
			.Select(c => c.IsArchive).WithAlias(() => carJournalNodeAlias.IsArchive)
			.Select(Projections.SqlFunction(
					   new SQLFunctionTemplate(NHibernateUtil.String, "CONCAT_WS(' ', ?2, ?1, ?3)"),
					   NHibernateUtil.String,
						   Projections.Property(() => driverAlias.Name),
					       Projections.Property(() => driverAlias.LastName),
						   Projections.Property(() => driverAlias.Patronymic))
						   )
						   .WithAlias(() => carJournalNodeAlias.DriverName))
				.TransformUsing(Transformers.AliasToBean<CarJournalNode>());

			return result;
		};

		protected override Func<CarsDlg> CreateDialogFunction => () => new CarsDlg();

		protected override Func<CarJournalNode, CarsDlg> OpenDialogFunction => (node) => new CarsDlg(node.Id);*/

		protected override Func<IUnitOfWork, IQueryOver<UndeliveredOrder>> ItemsSourceQueryFunction => (uow) =>
		{
			UndeliveredOrderJournalNode resultAlias = null;
			UndeliveredOrder undeliveredOrderAlias = null;
			Domain.Orders.Order oldOrderAlias = null;
			Domain.Orders.Order newOrderAlias = null;
			Employee driverAlias = null;
			Employee oldOrderAuthorAlias = null;
			Employee authorAlias = null;
			Employee editorAlias = null;
			Employee registratorAlias = null;
			//Employee employeeAlias = null;
			Nomenclature nomenclatureAlias = null;
			OrderItem orderItemAlias = null;
			OrderEquipment orderEquipmentAlias = null;
			Counterparty counterpartyAlias = null;
			DeliveryPoint undeliveredOrderDeliveryPointAlias = null;
			DeliverySchedule undeliveredOrderDeliveryScheduleAlias = null;
			DeliverySchedule newOrderDeliveryScheduleAlias = null;
			RouteList routeListAlias = null;
			RouteListItem routeListItemAlias = null;
			Subdivision subdivisionAlias = null;
			//UndeliveredOrderComment undeliveredOrderCommentsAlias = null;
			Fine fineAlias = null;
			FineItem fineItemAlias = null;
			Employee finedEmployeeAlias = null;
			Subdivision inProcessAtSubdivisionAlias = null;
			Subdivision authorSubdivisionAlias = null;
			GuiltyInUndelivery guiltyInUndeliveryAlias = null;

			var subqueryDrivers = QueryOver.Of<RouteListItem>(() => routeListItemAlias)
				.Where(() => routeListItemAlias.Order.Id == oldOrderAlias.Id)
				.Left.JoinQueryOver(i => i.RouteList, () => routeListAlias)
				.Left.JoinAlias(i => i.Driver, () => driverAlias)
				.Select(
					Projections.SqlFunction(
						new SQLFunctionTemplate(NHibernateUtil.String,
							"GROUP_CONCAT(CONCAT(?1, ' ', LEFT(?2,1),'.',LEFT(?3,1)) ORDER BY ?4 DESC SEPARATOR '\n\t↑\n')"), //⬆
						NHibernateUtil.String,
						Projections.Property(() => driverAlias.LastName),
						Projections.Property(() => driverAlias.Name),
						Projections.Property(() => driverAlias.Patronymic),
						Projections.Property(() => routeListItemAlias.Id)
					)
				);

			var subquery19LWaterQty = QueryOver.Of<OrderItem>(() => orderItemAlias)
				.Where(() => orderItemAlias.Order.Id == oldOrderAlias.Id)
				.Left.JoinQueryOver(i => i.Nomenclature, () => nomenclatureAlias)
				.Where(n => n.Category == NomenclatureCategory.water && n.TareVolume == TareVolume.Vol19L)
				.Select(Projections.Sum(() => orderItemAlias.Count));

			var subqueryGoodsToClient = QueryOver.Of<OrderEquipment>(() => orderEquipmentAlias)
				.Where(() => orderEquipmentAlias.Order.Id == oldOrderAlias.Id)
				.Where(() => orderEquipmentAlias.Direction == Direction.Deliver)
				.Left.JoinQueryOver(i => i.Nomenclature, () => nomenclatureAlias)
				.Select(
					Projections.SqlFunction(
						new SQLFunctionTemplate(NHibernateUtil.String,
							"TRIM(GROUP_CONCAT(CONCAT(IF(?1 IS NULL, ?2, ?1),':',?3) SEPARATOR ?4))"),
						NHibernateUtil.String,
						Projections.Property(() => nomenclatureAlias.ShortName),
						Projections.Property(() => nomenclatureAlias.Name),
						Projections.Property(() => orderEquipmentAlias.Count),
						Projections.Constant("\n")
					)
				);

			var subqueryGoodsFromClient = QueryOver.Of<OrderEquipment>(() => orderEquipmentAlias)
				.Where(() => orderEquipmentAlias.Order.Id == oldOrderAlias.Id)
				.Where(() => orderEquipmentAlias.Direction == Direction.PickUp)
				.Left.JoinQueryOver(i => i.Nomenclature, () => nomenclatureAlias)
				.Select(
					Projections.SqlFunction(
						new SQLFunctionTemplate(NHibernateUtil.String,
							"TRIM(GROUP_CONCAT(CONCAT(IF(?1 IS NULL, ?2, ?1),':',?3) SEPARATOR ?4))"),
						NHibernateUtil.String,
						Projections.Property(() => nomenclatureAlias.ShortName),
						Projections.Property(() => nomenclatureAlias.Name),
						Projections.Property(() => orderEquipmentAlias.Count),
						Projections.Constant("\n")
					)
				);

			var subqueryGuilty = QueryOver.Of<GuiltyInUndelivery>(() => guiltyInUndeliveryAlias)
				.Where(() => undeliveredOrderAlias.Id == guiltyInUndeliveryAlias.UndeliveredOrder.Id)
				.Left.JoinQueryOver(g => g.GuiltyDepartment, () => subdivisionAlias)
				.Select(
					Projections.SqlFunction(
						new SQLFunctionTemplate(NHibernateUtil.String,
							"GROUP_CONCAT(CONCAT(CASE ?1 WHEN 'Client' THEN 'Клиент' WHEN 'Driver' THEN 'Водитель' WHEN 'Department' THEN 'Отд' WHEN 'ServiceMan' THEN 'Мастер СЦ' WHEN 'ForceMajor' THEN 'Форс-мажор' WHEN 'None' THEN 'Нет (не недовоз)' ELSE 'Неизвестно' END, IF(?1 = 'Department' AND ?2 = '', ':Неизвестно', IF(?1 = 'Department' AND ?2 != '', CONCAT(':', ?2), ''))) SEPARATOR '\n')"),
						NHibernateUtil.String,
						Projections.Property(() => guiltyInUndeliveryAlias.GuiltySide),
						Projections.Property(() => subdivisionAlias.ShortName)
					)
				);

			var subqueryFined = QueryOver.Of<Fine>(() => fineAlias)
				.Where(() => fineAlias.UndeliveredOrder.Id == undeliveredOrderAlias.Id)
				.Left.JoinAlias(() => fineAlias.Items, () => fineItemAlias)
				.Left.JoinAlias(() => fineItemAlias.Employee, () => finedEmployeeAlias)
				.Select(
					Projections.SqlFunction(
						new SQLFunctionTemplate(NHibernateUtil.String, "GROUP_CONCAT(CONCAT_WS(': ', ?1, ?2) SEPARATOR '\n')"),
						NHibernateUtil.String,
						Projections.Property(() => finedEmployeeAlias.LastName),
						Projections.Property(() => fineItemAlias.Money)
					)
				);

			var query = UoW.Session.QueryOver<UndeliveredOrder>(() => undeliveredOrderAlias)
				.Left.JoinAlias(u => u.OldOrder, () => oldOrderAlias)
				.Left.JoinAlias(u => u.NewOrder, () => newOrderAlias)
				.Left.JoinAlias(() => oldOrderAlias.Client, () => counterpartyAlias)
				.Left.JoinAlias(() => newOrderAlias.DeliverySchedule, () => newOrderDeliveryScheduleAlias)
				.Left.JoinAlias(() => oldOrderAlias.Author, () => oldOrderAuthorAlias)
				.Left.JoinAlias(() => oldOrderAlias.DeliveryPoint, () => undeliveredOrderDeliveryPointAlias)
				.Left.JoinAlias(() => oldOrderAlias.DeliverySchedule, () => undeliveredOrderDeliveryScheduleAlias)
				.Left.JoinAlias(u => u.Author, () => authorAlias)
				.Left.JoinAlias(u => u.LastEditor, () => editorAlias)
				.Left.JoinAlias(u => u.EmployeeRegistrator, () => registratorAlias)
				.Left.JoinAlias(u => u.InProcessAtDepartment, () => inProcessAtSubdivisionAlias)
				.Left.JoinAlias(u => u.Author.Subdivision, () => authorSubdivisionAlias)
				.Left.JoinAlias(() => undeliveredOrderAlias.GuiltyInUndelivery, () => guiltyInUndeliveryAlias)
				.Left.JoinAlias(() => guiltyInUndeliveryAlias.GuiltyDepartment, () => subdivisionAlias);

			if(FilterViewModel?.RestrictDriver != null)
			{
				var oldOrderIds = UndeliveredOrdersRepository.GetListOfUndeliveryIdsForDriver(UoW, FilterViewModel.RestrictDriver);
				query.Where(() => oldOrderAlias.Id.IsIn(oldOrderIds.ToArray()));
			}

			if(FilterViewModel?.RestrictOldOrder != null)
			{
				query.Where(() => oldOrderAlias.Id == FilterViewModel.RestrictOldOrder.Id);
			}

			if(FilterViewModel?.RestrictClient != null)
			{
				query.Where(() => counterpartyAlias.Id == FilterViewModel.RestrictClient.Id);
			}

			if(FilterViewModel?.RestrictAddress != null)
			{
				query.Where(() => undeliveredOrderDeliveryPointAlias.Id == FilterViewModel.RestrictAddress.Id);
			}

			if(FilterViewModel?.RestrictAuthorSubdivision != null)
			{
				query.Where(() => authorAlias.Subdivision.Id == FilterViewModel.RestrictAuthorSubdivision.Id);
			}

			if(FilterViewModel?.RestrictOldOrderAuthor != null)
			{
				query.Where(() => oldOrderAuthorAlias.Id == FilterViewModel.RestrictOldOrderAuthor.Id);
			}

			if(FilterViewModel?.RestrictOldOrderStartDate != null)
			{
				query.Where(() => oldOrderAlias.DeliveryDate >= FilterViewModel.RestrictOldOrderStartDate);
			}

			if(FilterViewModel?.RestrictOldOrderEndDate != null)
			{
				query.Where(() => oldOrderAlias.DeliveryDate <= FilterViewModel.RestrictOldOrderEndDate.Value.AddDays(1).AddTicks(-1));
			}

			if(FilterViewModel?.RestrictNewOrderStartDate != null)
			{
				query.Where(() => newOrderAlias.DeliveryDate >= FilterViewModel.RestrictNewOrderStartDate);
			}

			if(FilterViewModel?.RestrictNewOrderEndDate != null)
			{
				query.Where(() => newOrderAlias.DeliveryDate <= FilterViewModel.RestrictNewOrderEndDate.Value.AddDays(1).AddTicks(-1));
			}

			if(FilterViewModel?.RestrictGuiltySide != null)
			{
				query.Where(() => guiltyInUndeliveryAlias.GuiltySide == FilterViewModel.RestrictGuiltySide);
			}

			if(FilterViewModel != null && FilterViewModel.RestrictIsProblematicCases)
			{
				query.Where(() => !guiltyInUndeliveryAlias.GuiltySide.IsIn(FilterViewModel.ExcludingGuiltiesForProblematicCases));
			}

			if(FilterViewModel?.RestrictGuiltyDepartment != null)
			{
				query.Where(() => subdivisionAlias.Id == FilterViewModel.RestrictGuiltyDepartment.Id);
			}

			if(FilterViewModel?.RestrictInProcessAtDepartment != null)
			{
				query.Where(u => u.InProcessAtDepartment.Id == FilterViewModel.RestrictInProcessAtDepartment.Id);
			}

			if(FilterViewModel?.NewInvoiceCreated != null)
			{
				if(FilterViewModel.NewInvoiceCreated.Value)
				{
					query.Where(u => u.NewOrder != null);
				}
				else
				{
					query.Where(u => u.NewOrder == null);
				}
			}

			if(FilterViewModel?.RestrictUndeliveryStatus != null)
			{
				query.Where(u => u.UndeliveryStatus == FilterViewModel.RestrictUndeliveryStatus);
			}

			if(FilterViewModel?.RestrictUndeliveryAuthor != null)
			{
				query.Where(u => u.Author == FilterViewModel.RestrictUndeliveryAuthor);
			}

			//if(undeliveryToShow > 0)
			//{
			//	query.Where(() => undeliveredOrderAlias.Id == undeliveryToShow);
			//}
			
			var addressProjection = Projections.SqlFunction(
				new SQLFunctionTemplate(NHibernateUtil.String,
					"CONCAT_WS(', ', ?1, CONCAT('д.', ?2), CONCAT('лит.', ?3), CONCAT('кв/оф ', ?4))"),
				NHibernateUtil.String,
				Projections.Property(() => undeliveredOrderDeliveryPointAlias.Street),
				Projections.Property(() => undeliveredOrderDeliveryPointAlias.Building),
				Projections.Property(() => undeliveredOrderDeliveryPointAlias.Letter),
				Projections.Property(() => undeliveredOrderDeliveryPointAlias.Room));

			var driverProjection =
				CustomProjections.Concat_WS(" ", () => driverAlias.LastName, () => driverAlias.Name, () => driverAlias.Patronymic);

			var oldOrderAuthorProjection = CustomProjections.Concat_WS(" ", 
				() => oldOrderAuthorAlias.LastName, () => oldOrderAuthorAlias.Name, () => oldOrderAuthorAlias.Patronymic);

			var registratorProjection = CustomProjections.Concat_WS(" ",
				() => registratorAlias.LastName, () => registratorAlias.Name, () => registratorAlias.Patronymic);

			var authorProjection = CustomProjections.Concat_WS(" ",
				() => authorAlias.LastName, () => authorAlias.Name, () => authorAlias.Patronymic);

			
			query.Where(GetSearchCriterion(
				() => undeliveredOrderAlias.Id,
				() => driverProjection,
				() => addressProjection,
				() => counterpartyAlias.Name,
				() => undeliveredOrderAlias.Reason,
				() => oldOrderAuthorProjection,
				() => registratorProjection,
				() => authorProjection)
			);

			var itemsQuery = query.SelectList(list => list
					.Select(() => newOrderAlias.Id).WithAlias(() => resultAlias.NewOrderId)
					.Select(() => newOrderAlias.DeliveryDate).WithAlias(() => resultAlias.NewOrderDeliveryDate)
					.Select(() => newOrderDeliveryScheduleAlias.Name).WithAlias(() => resultAlias.NewOrderDeliverySchedule)
					.SelectGroup(() => undeliveredOrderAlias.Id).WithAlias(() => resultAlias.Id)
					.Select(() => oldOrderAlias.Id).WithAlias(() => resultAlias.OldOrderId)
					.Select(() => oldOrderAlias.DeliveryDate).WithAlias(() => resultAlias.OldOrderDeliveryDateTime)
					.Select(() => undeliveredOrderAlias.DispatcherCallTime).WithAlias(() => resultAlias.DispatcherCallTime)
					.Select(() => undeliveredOrderAlias.DriverCallNr).WithAlias(() => resultAlias.DriverCallNr)
					.Select(() => undeliveredOrderAlias.DriverCallTime).WithAlias(() => resultAlias.DriverCallTime)
					.Select(() => undeliveredOrderAlias.DriverCallType).WithAlias(() => resultAlias.DriverCallType)
					.Select(() => counterpartyAlias.Name).WithAlias(() => resultAlias.Client)
					.Select(() => oldOrderAuthorAlias.LastName).WithAlias(() => resultAlias.OldOrderAuthorLastName)
					.Select(() => oldOrderAuthorAlias.Name).WithAlias(() => resultAlias.OldOrderAuthorFirstName)
					.Select(() => oldOrderAuthorAlias.Patronymic).WithAlias(() => resultAlias.OldOrderAuthorMidleName)
					.Select(() => undeliveredOrderDeliveryScheduleAlias.Name).WithAlias(() => resultAlias.OldDeliverySchedule)
					.Select(() => authorAlias.LastName).WithAlias(() => resultAlias.AuthorLastName)
					.Select(() => authorAlias.Name).WithAlias(() => resultAlias.AuthorFirstName)
					.Select(() => authorAlias.Patronymic).WithAlias(() => resultAlias.AuthorMidleName)
					.Select(() => registratorAlias.LastName).WithAlias(() => resultAlias.RegistratorLastName)
					.Select(() => registratorAlias.Name).WithAlias(() => resultAlias.RegistratorFirstName)
					.Select(() => registratorAlias.Patronymic).WithAlias(() => resultAlias.RegistratorMidleName)
					.Select(() => editorAlias.LastName).WithAlias(() => resultAlias.EditorLastName)
					.Select(() => editorAlias.Name).WithAlias(() => resultAlias.EditorFirstName)
					.Select(() => editorAlias.Patronymic).WithAlias(() => resultAlias.EditorMidleName)
					.Select(() => undeliveredOrderAlias.Reason).WithAlias(() => resultAlias.Reason)
					.Select(() => undeliveredOrderAlias.UndeliveryStatus).WithAlias(() => resultAlias.UndeliveryStatus)
					.Select(() => undeliveredOrderAlias.OldOrderStatus).WithAlias(() => resultAlias.StatusOnOldOrderCancel)
					.Select(() => oldOrderAlias.OrderStatus).WithAlias(() => resultAlias.OldOrderCurStatus)
					.Select(() => inProcessAtSubdivisionAlias.Name).WithAlias(() => resultAlias.InProcessAt)
					.SelectSubQuery(subqueryDrivers).WithAlias(() => resultAlias.OldRouteListDriverName)
					.SelectSubQuery(subquery19LWaterQty).WithAlias(() => resultAlias.OldOrder19LBottleQty)
					.SelectSubQuery(subqueryGoodsToClient).WithAlias(() => resultAlias.OldOrderGoodsToClient)
					.SelectSubQuery(subqueryGoodsFromClient).WithAlias(() => resultAlias.OldOrderGoodsFromClient)
					.SelectSubQuery(subqueryFined).WithAlias(() => resultAlias.Fined)
					.SelectSubQuery(subqueryGuilty).WithAlias(() => resultAlias.Guilty)
					.Select(addressProjection).WithAlias(() => resultAlias.Address)
				).OrderBy(() => oldOrderAlias.DeliveryDate).Asc
				.TransformUsing(Transformers.AliasToBean<UndeliveredOrderJournalNode>());

			return itemsQuery;
		};

		protected void BeforeItemsUpdated(IList items, uint start)
		{
			foreach(var item in items.Cast<UndeliveredOrderJournalNode>().Skip((int)start))
			{
				item.NumberInList = items.IndexOf(item) + 1;
			}
		}
		protected override Func<UndeliveredOrderViewModel> CreateDialogFunction =>
			() => new UndeliveredOrderViewModel(EntityUoWBuilder.ForCreate(), UnitOfWorkFactory, commonServices);

		protected override Func<UndeliveredOrderJournalNode, UndeliveredOrderViewModel> OpenDialogFunction =>
			node => new UndeliveredOrderViewModel(EntityUoWBuilder.ForOpen(node.Id), UnitOfWorkFactory, commonServices);

		public event EventHandler<CurrentObjectChangedArgs> CurrentObjectChanged;
		public PanelViewType[] InfoWidgets => new[] { PanelViewType.UndeliveredOrdersPanelView };
		public UndeliveredOrdersFilterViewModel UndeliveredOrdersFilterViewModel => FilterViewModel;
	}
}
