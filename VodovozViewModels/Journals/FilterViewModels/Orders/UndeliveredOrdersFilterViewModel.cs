using QS.Project.Filter;
using QS.Project.Journal;
using QS.Project.Journal.EntitySelector;
using QS.Services;
using System;
using System.Collections.Generic;
using QS.Commands;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Employees;
using Vodovoz.Domain.Orders;
using Vodovoz.TempAdapters;
using Vodovoz.ViewModels.Journals.FilterViewModels.Enums;
using Vodovoz.ViewModels.Journals.JournalFactories;
using Vodovoz.ViewModels.TempAdapters;

namespace Vodovoz.ViewModels.Journals.FilterViewModels.Orders
{
	public class UndeliveredOrdersFilterViewModel : FilterViewModelBase<UndeliveredOrdersFilterViewModel>
	{
		private Order _restrictOldOrder;
		private Employee _restrictDriver;
		private Subdivision _restrictAuthorSubdivision;
		private Counterparty _restrictClient;
		private DeliveryPoint _restrictAddress;
		private Employee _restrictOldOrderAuthor;
		private DateTime? _restrictOldOrderStartDate;
		private DateTime? _restrictOldOrderEndDate;
		private DateTime? _restrictNewOrderStartDate;
		private DateTime? _restrictNewOrderEndDate;
		private GuiltyTypes? _restrictGuiltySide;
		private Subdivision _restrictGuiltyDepartment;
		private Subdivision _restrictInProcessAtDepartment;
		//private ActionsWithInvoice? _restrictActionsWithInvoice
		private UndeliveryStatus? _restrictUndeliveryStatus;
		private Employee _restrictUndeliveryAuthor;
		private bool _restrictIsProblematicCases;
		private bool _restrictNotIsProblematicCases;
		private ActionsWithInvoice? _restrictActionsWithInvoice;
		private bool _restrictGuiltyDepartmentVisible;
		private DelegateCommand _resetGuiltyCommand;

		private readonly ICommonServices _commonServices;
		private readonly IOrderSelectorFactory _orderSelectorFactory;
		private readonly IEmployeeJournalFactory _employeeJournalFactory;
		private readonly ICounterpartyJournalFactory _counterpartyJournalFactory;
		private readonly IDeliveryPointJournalFactory _deliveryPointJournalFactory;
		private readonly ISubdivisionJournalFactory _subdivisionJournalFactory;
		private readonly IJournalFilter _driverJournalFilter;
		private readonly IJournalFilter _oldOrderAuthorJournalFilter;
		private readonly IJournalFilter _subdivisionJournalFilter;

		private void Configure()
		{
			OrderSelectorFactory = _orderSelectorFactory.GetOrderJournalFactory();
			DriverSelectorFactory = _employeeJournalFactory.CreateEmployeeAutocompleteSelectorFactory(_driverJournalFilter);
			AuthorSelectorFactory = _employeeJournalFactory.CreateEmployeeAutocompleteSelectorFactory(_oldOrderAuthorJournalFilter);
			CounterpartySelectorFactory = _counterpartyJournalFactory.CreateCounterpartyAutocompleteSelectorFactory();
			DeliveryPointSelectorFactory = _deliveryPointJournalFactory.CreateDeliveryPointAutocompleteSelectorFactory();
			SubdivisionSelectorFactory =
				_subdivisionJournalFactory.CreateSubdivisionAutocompleteSelectorFactory(_employeeJournalFactory
					.CreateEmployeeAutocompleteSelectorFactory(_subdivisionJournalFilter));
			CanDelete = _commonServices.CurrentPermissionService.ValidatePresetPermission("can_delete");

			Subdivisions = UoW.GetAll<Subdivision>();
			RestrictUndeliveryStatus = UndeliveryStatus.InProcess;
			RestrictNotIsProblematicCases = true;
			RestrictOldOrderStartDate = DateTime.Today.AddMonths(-1);
			RestrictOldOrderEndDate = DateTime.Today.AddMonths(1);
		}
		//private readonly IOrderSelectorFactory _orderSelectorFactory;
		public UndeliveredOrdersFilterViewModel(ICommonServices commonServices, IOrderSelectorFactory orderSelectorFactory, IEmployeeJournalFactory employeeJournalFactory, ICounterpartyJournalFactory counterpartyJournalFactory, IDeliveryPointJournalFactory deliveryPointJournalFactory, ISubdivisionJournalFactory subdivisionJournalFactory, IJournalFilter driverJournalFilter, IJournalFilter oldOrderAuthorJournalFilter, IJournalFilter subdivisionJournalFilter)
		{
			//_orderSelectorFactory = orderSelectorFactory ?? throw new ArgumentNullException(nameof(orderSelectorFactory));
			/*var employeeSelectorFactory =
				new DefaultEntityAutocompleteSelectorFactory
					<Employee, EmployeesJournalViewModel, EmployeeFilterViewModel>(ServicesConfig.CommonServices);
			var filter = new SubdivisionFilterViewModel() { SubdivisionType = SubdivisionType.Default };
			var v =
				new EntityAutocompleteSelectorFactory<SubdivisionsJournalViewModel>(
					typeof(Subdivision),
					() => new SubdivisionsJournalViewModel(
						filter,
						UnitOfWorkFactory.GetDefaultFactory,
						ServicesConfig.CommonServices,
						filter
					)
			*/
			_commonServices = commonServices ?? throw new ArgumentNullException(nameof(commonServices));
			_orderSelectorFactory = orderSelectorFactory ?? throw new ArgumentNullException(nameof(orderSelectorFactory));
			_employeeJournalFactory = employeeJournalFactory ?? throw new ArgumentNullException(nameof(commonServices));
			_counterpartyJournalFactory = counterpartyJournalFactory ?? throw new ArgumentNullException(nameof(counterpartyJournalFactory));
			_deliveryPointJournalFactory = deliveryPointJournalFactory ?? throw new ArgumentNullException(nameof(deliveryPointJournalFactory));
			_subdivisionJournalFactory = subdivisionJournalFactory ?? throw new ArgumentNullException(nameof(subdivisionJournalFactory));

			_driverJournalFilter = driverJournalFilter;
			_oldOrderAuthorJournalFilter = oldOrderAuthorJournalFilter;
			_subdivisionJournalFilter = subdivisionJournalFilter;
			Configure();
		}

		public UndeliveredOrdersFilterViewModel(ICommonServices commonServices, IOrderSelectorFactory orderSelectorFactory, IEmployeeJournalFactory employeeJournalFactory, ICounterpartyJournalFactory counterpartyJournalFactory, IDeliveryPointJournalFactory deliveryPointJournalFactory, ISubdivisionJournalFactory subdivisionJournalFactory)
		{
			_commonServices = commonServices ?? throw new ArgumentNullException(nameof(commonServices));
			_orderSelectorFactory = orderSelectorFactory ?? throw new ArgumentNullException(nameof(orderSelectorFactory));
			_employeeJournalFactory = employeeJournalFactory ?? throw new ArgumentNullException(nameof(commonServices));
			_counterpartyJournalFactory = counterpartyJournalFactory ?? throw new ArgumentNullException(nameof(counterpartyJournalFactory));
			_deliveryPointJournalFactory = deliveryPointJournalFactory ?? throw new ArgumentNullException(nameof(deliveryPointJournalFactory));
			_subdivisionJournalFactory = subdivisionJournalFactory ?? throw new ArgumentNullException(nameof(subdivisionJournalFactory));

			Configure();
		}

		public IEntityAutocompleteSelectorFactory OrderSelectorFactory { get; private set; }
		public IEntityAutocompleteSelectorFactory DriverSelectorFactory { get; private set; }
		public IEntityAutocompleteSelectorFactory AuthorSelectorFactory { get; private set; }
		public IEntityAutocompleteSelectorFactory CounterpartySelectorFactory { get; private set; }
		public IEntityAutocompleteSelectorFactory DeliveryPointSelectorFactory { get; private set; }
		public IEntityAutocompleteSelectorFactory SubdivisionSelectorFactory { get; private set; }
		public bool CanDelete { get; private set; }

		public Order RestrictOldOrder
		{
			get => _restrictOldOrder;
			set => UpdateFilterField(ref _restrictOldOrder, value);
		}

		public Employee RestrictDriver
		{
			get => _restrictDriver;
			set => UpdateFilterField(ref _restrictDriver, value);
		}

		public Subdivision RestrictAuthorSubdivision
		{
			get => _restrictAuthorSubdivision;
			set => UpdateFilterField(ref _restrictAuthorSubdivision, value);
		}

		public Counterparty RestrictClient
		{
			get => _restrictClient;
			set => UpdateFilterField(ref _restrictClient, value);
		}

		public DeliveryPoint RestrictAddress
		{
			get => _restrictAddress;
			set => UpdateFilterField(ref _restrictAddress, value);
		}

		public Employee RestrictOldOrderAuthor
		{
			get => _restrictOldOrderAuthor;
			set => UpdateFilterField(ref _restrictOldOrderAuthor, value);
		}

		public DateTime? RestrictOldOrderStartDate
		{
			get => _restrictOldOrderStartDate;
			set => UpdateFilterField(ref _restrictOldOrderStartDate, value);
		}

		public DateTime? RestrictOldOrderEndDate
		{
			get => _restrictOldOrderEndDate;
			set => UpdateFilterField(ref _restrictOldOrderEndDate, value);
		}

		public DateTime? RestrictNewOrderStartDate
		{
			get => _restrictNewOrderStartDate;
			set => UpdateFilterField(ref _restrictNewOrderStartDate, value);
		}

		public DateTime? RestrictNewOrderEndDate
		{
			get => _restrictNewOrderEndDate;
			set => UpdateFilterField(ref _restrictNewOrderEndDate, value);
		}

		public GuiltyTypes? RestrictGuiltySide
		{
			get => _restrictGuiltySide;
			set
			{
				if(value == GuiltyTypes.Department)
				{
					RestrictGuiltyDepartmentVisible = true;
				}
				else
				{
					RestrictGuiltyDepartmentVisible = false;
					RestrictGuiltyDepartment = null;
				}
				UpdateFilterField(ref _restrictGuiltySide, value);
			}
		}

		public bool RestrictGuiltyDepartmentVisible
		{
			get => _restrictGuiltyDepartmentVisible;
			set => UpdateFilterField(ref _restrictGuiltyDepartmentVisible, value);
		}

		public Subdivision RestrictGuiltyDepartment
		{
			get => _restrictGuiltyDepartment;
			set => UpdateFilterField(ref _restrictGuiltyDepartment, value);
		}

		public Subdivision RestrictInProcessAtDepartment
		{
			get => _restrictInProcessAtDepartment;
			set => UpdateFilterField(ref _restrictInProcessAtDepartment, value);
		}

		public ActionsWithInvoice? RestrictActionsWithInvoice
		{
			get => _restrictActionsWithInvoice;
			set
			{
				switch(value)
				{
					case ActionsWithInvoice.createdNew:
						NewInvoiceCreated = true;
						break;
					case ActionsWithInvoice.notCreated:
						NewInvoiceCreated = false;
						break;
					default:
						NewInvoiceCreated = null;
						break;
				}
				UpdateFilterField(ref _restrictActionsWithInvoice, value);
			}
		}

		public bool? NewInvoiceCreated { get; set; }

		public UndeliveryStatus? RestrictUndeliveryStatus
		{
			get => _restrictUndeliveryStatus;
			set => UpdateFilterField(ref _restrictUndeliveryStatus, value);
		}

		public Employee RestrictUndeliveryAuthor
		{
			get => _restrictUndeliveryAuthor;
			set => UpdateFilterField(ref _restrictUndeliveryAuthor, value);
		}

		public bool RestrictIsProblematicCases
		{
			get => _restrictIsProblematicCases;
			set
			{
				if(value)
				{
					RestrictGuiltySide = null;
				}

				RestrictNotIsProblematicCases = !value;

				UpdateFilterField(ref _restrictIsProblematicCases, value);
			}
		}

		public bool RestrictNotIsProblematicCases
		{
			get => _restrictNotIsProblematicCases;
			set => UpdateFilterField(ref _restrictNotIsProblematicCases, value);
		}

		public IEnumerable<Subdivision> Subdivisions { get; private set; }

		//public DelegateCommand ResetGuiltyCommand => _resetGuiltyCommand ?? (_resetGuiltyCommand =
		//	new DelegateCommand(() =>
		//		{
		//			//if(RestrictIsProblematicCases)
		//			//{
		//				/*Entity.Driver = (Entity.Car.Driver != null && Entity.Car.Driver.Status != EmployeeStatus.IsFired)
		//					? Entity.Car.Driver
		//					: null;*/
		//			//}
		//		},
		//		() => true
		//	));
		public GuiltyTypes[] ExcludingGuiltiesForProblematicCases => new GuiltyTypes[] { GuiltyTypes.Client, GuiltyTypes.None };
	}
}
