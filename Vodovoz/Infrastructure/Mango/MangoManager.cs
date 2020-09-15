﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ClientMangoService;
using Gtk;
using MangoService;
using NLog;
using QS.DomainModel.Entity;
using QS.DomainModel.NotifyChange;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Services;
using QS.Utilities;
using Vodovoz.Core.DataService;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Contacts;
using Vodovoz.Domain.Employees;
using Vodovoz.EntityRepositories;
using Vodovoz.Infrastructure.Services;
using Vodovoz.Repositories;
using Vodovoz.Repositories.Client;
using Vodovoz.ViewModels.Mango;
using Vodovoz.ViewModels.Mango.Talks;

namespace Vodovoz.Infrastructure.Mango
{
	public class MangoManager : PropertyChangedBase, IDisposable
	{
		private static Logger logger = LogManager.GetCurrentClassLogger ();
		private readonly Gtk.Action toolbarIcon;
		private readonly IUnitOfWorkFactory unitOfWorkFactory;
		private readonly IEmployeeService employeeService;
		private readonly IUserService userService;
		private readonly INavigationManager navigation;
		private readonly PhoneRepository phoneRepository;
		private ConnectionState connectionState;
		private uint extension;
		private MangoNotificationClient notificationClient;
		private readonly CancellationTokenSource notificationCancellation = new CancellationTokenSource();
		private NotificationMessage LastMessage;
		private IPage CurrentPage;
		private uint timer;
		private MangoService.MangoController mangoController;

		public MangoManager(Gtk.Action toolbarIcon,
			IUnitOfWorkFactory unitOfWorkFactory,
			IEmployeeService employeeService,
			IUserService userService,
			INavigationManager navigation,
			BaseParametersProvider parametrs,
			PhoneRepository phoneRepository)
		{
			this.toolbarIcon = toolbarIcon;
			this.unitOfWorkFactory = unitOfWorkFactory ?? throw new ArgumentNullException(nameof(unitOfWorkFactory));
			this.employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
			this.userService = userService ?? throw new ArgumentNullException(nameof(userService));
			this.navigation = navigation ?? throw new ArgumentNullException(nameof(navigation));
			this.phoneRepository = phoneRepository ?? throw new ArgumentNullException(nameof(phoneRepository));
 			this.mangoController = new MangoService.MangoController(parametrs.VpbxApiKey, parametrs.VpbxApiSalt);

			timer = GLib.Timeout.Add (1000, new GLib.TimeoutHandler(HandleTimeoutHandler));
			toolbarIcon.Activated += ToolbarIcon_Activated;
			var userId = this.userService.CurrentUserId;
			QS.DomainModel.NotifyChange.NotifyConfiguration.Instance.BatchSubscribe(OnUserChanged).IfEntity<Employee>()
				.AndWhere(x => x.User.Id == userId);
		}

		public ConnectionState ConnectionState {
			#region Current State
			get => connectionState; private set {
				connectionState = value;
				var iconName = $"phone-{value.ToString().ToLower()}";
				toolbarIcon.StockId = iconName;
				if(ConnectionState == ConnectionState.Connected || ConnectionState == ConnectionState.Disconnected)
					toolbarIcon.ShortLabel = extension.ToString();
				else
					toolbarIcon.ShortLabel = "Mango";
				GtkHelper.WaitRedraw();
			}
		}

		public DateTime? StageBegin => LastMessage?.Timestamp.ToDateTime();
		public TimeSpan? StageDuration => DateTime.Now - StageBegin;

		public string CallerName => LastMessage.CallFrom.Names != null ? String.Join("\n", LastMessage.CallFrom.Names.Select(x => x.Name)) : null;
		public string CallerNumber => LastMessage?.CallFrom.Number;
		public bool IsTransfer => LastMessage.IsTransfer;
		public Caller PrimaryCaller => LastMessage?.PrimaryCaller;

			//Point!
		//FIXME Тестовая заглушка телефона и имени
		//public string CallerNumber { get; set; }
		//public string CallerName { get; set; }


		public List<IncomingCall> IncomingCalls { get; set; } = new List<IncomingCall>();
		#endregion

		#region Методы

		public void Connect()
		{
			using(var uow = unitOfWorkFactory.CreateWithoutRoot("MangoManager Connect")) {
				var employee = employeeService.GetEmployeeForUser(uow, userService.CurrentUserId);
				if(employee?.InnerPhone == null) {
					ConnectionState = ConnectionState.Disable;
					return;
				}

				extension = employee.InnerPhone.Value;
				ConnectionState = ConnectionState.Disconnected;
				notificationClient = new MangoNotificationClient(extension, notificationCancellation.Token);
				notificationClient.ChanalStateChanged+= NotificationClient_ChanalStateChanged;
				ConnectionState = notificationClient.IsNotificationActive ? ConnectionState.Connected : ConnectionState.Disconnected;
				notificationClient.IncomeCall += NotificationClientOnIncomeCall;
			}
		}

		#endregion
		#region Обработка событий
		private void OnUserChanged(EntityChangeEvent[] changeevents)
		{
			logger.Info("Текущий сотрудник именён, мог поменятся номер привязки, переподключаемся...");
			notificationCancellation.Cancel();
			if(notificationClient != null)
				notificationClient.Dispose();
			Connect();
		}

		private void NotificationClientOnIncomeCall(object sender, IncomeCallEventArgs e)
		{
			LastMessage = e.Message;
			Application.Invoke((s, arg) => HandleMessage(e.Message));
		}

		void NotificationClient_ChanalStateChanged(object sender, ConnectionStateEventArgs e)
		{
			Gtk.Application.Invoke(delegate {
				ConnectionState = notificationClient.IsNotificationActive ? ConnectionState.Connected : ConnectionState.Disconnected;
			});
		}

		void ToolbarIcon_Activated(object sender, EventArgs e)
		{
			if(CurrentPage == null) {
				if(LastMessage != null)
					HandleMessage(LastMessage);
				else {
					CurrentPage = navigation.OpenViewModel<SubscriberSelectionViewModel, MangoManager, SubscriberSelectionViewModel.DialogType>(null, this, SubscriberSelectionViewModel.DialogType.Telephone);
					CurrentPage.PageClosed += CurrentPage_PageClosed;
				}
			} 
		}

		void CurrentPage_PageClosed(object sender, PageClosedEventArgs e)
		{
			CurrentPage = null;
		}

		bool HandleTimeoutHandler()
		{
			if(LastMessage != null)
				OnPropertyChanged(nameof(StageDuration));
			if(IncomingCalls.Any())
				OnPropertyChanged("IncomingCalls.Time");
			return true;
		}

		#endregion
		#region Private

		List<Counterparty> clients = null;
		public List<Counterparty> Clients { get => clients; private set => clients = value; }
		Employee employee = null;
		public Employee Employee { get => employee; private set => employee = value; }
		List<DeliveryPoint> deliveryPoints = null;
		public List<DeliveryPoint> DeliveryPoints { get => deliveryPoints;private set => deliveryPoints = value; }

		private void FoundByPhoneItemsConfigure()
		{
			using (var uow = unitOfWorkFactory.CreateWithoutRoot())
			{
				foreach (var item in LastMessage.CallFrom.Names)
				{
					int id = Convert.ToInt32(item.CounterpartyId);
					Counterparty client = uow.GetById<Counterparty>(id);
					if (client != null)
						clients.Add(client);

					id = Convert.ToInt32(item.EmployeeId);
					Employee employee = uow.GetById<Employee>(id);
					if (employee != null)
						this.employee = employee;

					id = Convert.ToInt32(item.DeliveryPointId);
					DeliveryPoint deliveryPoint = uow.GetById<DeliveryPoint>(id);
					if (deliveryPoint != null)
						DeliveryPoints.Add(deliveryPoint);
				}
			}
		}


		//Point!
		private void FoundByPhoneItemsConfigureTest()
		{
			//CallerName = "ООО Ленинградские булочные";
			//CallerNumber = "+79536600012";
			object[] objects = phoneRepository.GetObjectByPhone(unitOfWorkFactory.CreateWithoutRoot(),CallerNumber);
			foreach(var item in objects) {
				if(item.GetType().Name == "Counterparty")
					clients.Add((Counterparty)item);
				else if(item.GetType().Name == "DeliveryPoint")
					deliveryPoints.Add((DeliveryPoint)item);
				else if(item.GetType().Name == "Employee")
					employee = (Employee)item;
			}
		}

		#endregion
		#region Работа с сообщениями

		private void HandleMessage(NotificationMessage message)
		{
			if(message.State == CallState.Appeared) {
				AddNewIncome(message);
				//Point!
				//FoundByPhoneItemsConfigureTest();
				if(CurrentPage == null) {
					CurrentPage = navigation.OpenViewModel<IncomingCallViewModel, MangoManager>(null, this);
					CurrentPage.PageClosed += CurrentPage_PageClosed;
				}
				return;
			}

			if(message.State == CallState.Disconnected) {
				if(TryRemoveIncome(message)) { //HACK сожалению другие способы уменьшения окна с телефонами не сработали. Поэтому просто преотрываем окно.
					if(CurrentPage != null)
						navigation.ForceClosePage(CurrentPage);
					if(IncomingCalls.Any()) {
						CurrentPage = navigation.OpenViewModel<IncomingCallViewModel, MangoManager>(null, this);
						CurrentPage.PageClosed += CurrentPage_PageClosed;
					}
					return;
				}
				LastMessage = null;
			}

			if(CurrentPage != null) {
				navigation.ForceClosePage(CurrentPage);
			}

			if(message.State == CallState.Connected)
			{
				FoundByPhoneItemsConfigure();
				if(message.CallFrom.Type == CallerType.Internal) {
					CurrentPage = navigation.OpenViewModel<UnknowTalkViewModel, MangoManager>(null,this);
					CurrentPage.PageClosed += CurrentPage_PageClosed;
				}
				else
				{
					if(clients != null) {
						CurrentPage = navigation.OpenViewModel<CounterpartyTalkViewModel, MangoManager, IEnumerable<Counterparty>>(null, this, clients);
						CurrentPage.PageClosed += CurrentPage_PageClosed;
					} else {
						CurrentPage = navigation.OpenViewModel<UnknowTalkViewModel, MangoManager>(null, this);
						CurrentPage.PageClosed += CurrentPage_PageClosed;
					}
				}
			}

			if(CurrentPage != null)
				CurrentPage.PageClosed += CurrentPage_PageClosed;
		}

		private void AddNewIncome(NotificationMessage message)
		{
			IncomingCalls.Add(new IncomingCall(message));
			OnPropertyChanged(nameof(IncomingCalls));
		}

		private bool TryRemoveIncome(NotificationMessage message)
		{
			if(IncomingCalls.RemoveAll(x => x.CallId == message.CallId) > 0) {
				OnPropertyChanged(nameof(IncomingCalls));
				return true;
			}
			return false;
		}

		public void AddedCounterpartyToCall(Counterparty client , bool changeCallState)
		{
			if(clients == null)
				clients = new List<Counterparty>();
			clients.Add(client);
			if(changeCallState) {
				CurrentPage = navigation.OpenViewModel<CounterpartyTalkViewModel, MangoManager, IEnumerable<Counterparty>>(null, this, clients);
				CurrentPage.PageClosed += CurrentPage_PageClosed;
				//if(LastMessage != null && CurrentPage == null)
					//HandleMessage(LastMessage);
			}
		}

		#endregion
		#region MangoController_Methods

		public void HangUp()
		{
			mangoController.HangUp(LastMessage.CallId);
		}

		public IEnumerable<MangoService.DTO.Group.Group> GetAllVPBXGroups()
		{
			return mangoController.GetAllVpbxGroups();
		}

		public IEnumerable<MangoService.DTO.Users.User> GetAllVPBXEmploies()
		{
			return mangoController.GetAllVPBXEmploies();
		}

		public void MakeCall(string to_extension)
		{
			mangoController.MakeCall(Convert.ToString(this.extension),to_extension);
		}

		public void ForwardCall(string to_extension,ForwardingMethod method)
		{
			mangoController.ForwardCall(LastMessage.CallId,Convert.ToString(this.extension),to_extension, method);
		}

		#endregion
		public void Dispose()
		{
			NotifyConfiguration.Instance.UnsubscribeAll(this);
			notificationCancellation.Cancel();
			if(notificationClient != null)
				notificationClient.Dispose();
			GLib.Source.Remove(timer);
		}

	}

	public enum ConnectionState
	{
		Connected,
		Disable,
		Disconnected,
		Ring,
		Talk
	}
}
