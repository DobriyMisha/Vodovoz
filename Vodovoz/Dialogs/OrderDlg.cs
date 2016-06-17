﻿using System;
using System.Collections.Generic;
using System.Linq;
using Gamma.GtkWidgets;
using Gamma.Utilities;
using Gtk;
using NHibernate.Proxy;
using NLog;
using QSOrmProject;
using QSProjectsLib;
using QSReport;
using QSTDI;
using QSValidation;
using Vodovoz.Domain;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Employees;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Logistic;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.Orders.Documents;
using Vodovoz.Domain.Service;
using Vodovoz.Panel;
using Vodovoz.Repository;

namespace Vodovoz
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class OrderDlg : OrmGtkDialogBase<Order>, ICounterpartyInfoProvider, IDeliveryPointInfoProvider
	{
		static Logger logger = LogManager.GetCurrentClassLogger ();

		public event EventHandler<CurrentObjectChangedArgs> CurrentObjectChanged;

		public PanelViewType[] InfoWidgets
		{
			get
			{
				return new[]{
					PanelViewType.CounterpartyView, 
					PanelViewType.DeliveryPointView, 
					PanelViewType.AdditionalAgreementPanelView 
				};
			}
		}

		public Counterparty Counterparty
		{
			get
			{
				return referenceClient.Subject as Counterparty;
			}
		}

		public DeliveryPoint DeliveryPoint
		{
			get
			{
				return referenceDeliveryPoint.Subject as DeliveryPoint;
			}
		}

		public OrderDlg ()
		{
			this.Build ();
			UoWGeneric = UnitOfWorkFactory.CreateWithNewRoot<Order> ();
			Entity.Author = EmployeeRepository.GetEmployeeForCurrentUser (UoW);
			if (Entity.Author == null) {
				MessageDialogWorks.RunErrorDialog ("Ваш пользователь не привязан к действующему сотруднику, вы не можете создавать создавать заказы, так как некого указывать в качестве автора документа.");
				FailInitialize = true;
				return;
			}
			UoWGeneric.Root.OrderStatus = OrderStatus.NewOrder;
			TabName = "Новый заказ";
			ConfigureDlg ();
		}

		public OrderDlg (int id)
		{
			this.Build ();
			UoWGeneric = UnitOfWorkFactory.CreateForRoot<Order> (id);
			ConfigureDlg ();
		}

		public OrderDlg (Order sub) : this (sub.Id)
		{
		}

		public void ConfigureDlg ()
		{
			treeDocuments.Selection.Mode=SelectionMode.Multiple;
			if (UoWGeneric.Root.PreviousOrder != null) {
				labelPreviousOrder.Text = "Посмотреть предыдущий заказ";
//TODO Make it clickable.
			} else
				labelPreviousOrder.Visible = false;
			hboxStatusButtons.Visible = (UoWGeneric.Root.OrderStatus == OrderStatus.NewOrder 
				|| UoWGeneric.Root.OrderStatus == OrderStatus.Accepted || Entity.OrderStatus == OrderStatus.Canceled);
			UpdateButtonState();

			treeDocuments.ItemsDataSource = UoWGeneric.Root.ObservableOrderDocuments;
			treeItems.ItemsDataSource = UoWGeneric.Root.ObservableOrderItems;
			treeEquipment.ItemsDataSource = UoWGeneric.Root.ObservableOrderEquipments;
			treeDepositRefundItems.ItemsDataSource = UoWGeneric.Root.ObservableOrderDepositItems;
			treeServiceClaim.ItemsDataSource = UoWGeneric.Root.ObservableInitialOrderService;
			//TODO FIXME Добавить в таблицу закрывающие заказы.

			//Подписывемся на изменения листов для засеривания клинета
			Entity.ObservableOrderDocuments.ElementAdded += Entity_UpdateClientCanChange;
			Entity.ObservableFinalOrderService.ElementAdded += Entity_UpdateClientCanChange;
			Entity.ObservableInitialOrderService.ElementAdded += Entity_UpdateClientCanChange;

			enumSignatureType.ItemsEnum = typeof(OrderSignatureType);
			enumSignatureType.Binding.AddBinding (Entity, s => s.SignatureType, w => w.SelectedItem).InitializeFromSource ();

			enumPaymentType.ItemsEnum = typeof(PaymentType);
			enumPaymentType.Binding.AddBinding (Entity, s => s.PaymentType, w => w.SelectedItem).InitializeFromSource ();

			enumStatus.ItemsEnum = typeof(OrderStatus);
			enumStatus.Binding.AddBinding (Entity, s => s.OrderStatus, w => w.SelectedItem).InitializeFromSource ();

			pickerDeliveryDate.Binding.AddBinding (Entity, s => s.DeliveryDate, w => w.DateOrNull).InitializeFromSource ();

			textComments.Binding.AddBinding (Entity, s => s.Comment, w => w.Buffer.Text).InitializeFromSource ();

			checkSelfDelivery.Binding.AddBinding (Entity, s => s.SelfDelivery, w => w.Active).InitializeFromSource ();
			checkDelivered.Binding.AddBinding (Entity, s => s.Shipped, w => w.Active).InitializeFromSource ();

			ycheckbuttonCollectBottles.Binding.AddBinding(Entity, s => s.CollectBottles, w => w.Active).InitializeFromSource();

			spinBottlesReturn.Binding.AddBinding (Entity, s => s.BottlesReturn, w => w.ValueAsInt).InitializeFromSource ();

			referenceClient.ItemsQuery = CounterpartyRepository.ActiveClientsQuery ();
			referenceClient.SetObjectDisplayFunc<Counterparty> (e => e.Name);
			referenceClient.Binding.AddBinding (Entity, s => s.Client, w => w.Subject).InitializeFromSource ();

			referenceDeliverySchedule.ItemsQuery = DeliveryScheduleRepository.AllQuery ();
			referenceDeliverySchedule.SetObjectDisplayFunc<DeliverySchedule> (e => e.Name);
			referenceDeliverySchedule.Binding.AddBinding (Entity, s => s.DeliverySchedule, w => w.Subject).InitializeFromSource ();

			referenceAuthor.ItemsQuery = EmployeeRepository.ActiveEmployeeOrderedQuery ();
			referenceAuthor.SetObjectDisplayFunc<Employee> (e => e.ShortName);
			referenceAuthor.Binding.AddBinding (Entity, s => s.Author, w => w.Subject).InitializeFromSource ();
			referenceAuthor.Sensitive = false;

			referenceDeliveryPoint.Binding.AddBinding (Entity, s => s.DeliveryPoint, w => w.Subject).InitializeFromSource ();
			referenceDeliveryPoint.Sensitive = (UoWGeneric.Root.Client != null);

			buttonViewDocument.Sensitive = false;
			buttonDelete.Sensitive = false;
			enumStatus.Sensitive = false;
			notebook1.ShowTabs = false;
			notebook1.Page = 0;

			referenceDeliverySchedule.SubjectType = typeof(DeliverySchedule);

			#region Events
			treeDocuments.Selection.Changed += (sender, e) => {
				buttonViewDocument.Sensitive = treeDocuments.Selection.CountSelectedRows () > 0;
			};

			treeDocuments.RowActivated += (o, args) => buttonViewDocument.Click ();

			enumAddRentButton.ItemsEnum = typeof(OrderAgreementType);
			enumAddRentButton.EnumItemClicked += (sender, e) => AddRentAgreement ((OrderAgreementType)e.ItemEnum);
				
			checkSelfDelivery.Toggled += (sender, e) => {
				referenceDeliverySchedule.Sensitive = labelDeliverySchedule.Sensitive = !checkSelfDelivery.Active;
			};

			UoWGeneric.Root.ObservableOrderItems.ElementChanged += (aList, aIdx) => {
				FixPrice (aIdx [0]);
				enumPaymentType.Sensitive = UoWGeneric.Root.CanChangePaymentType ();
			};

			UoWGeneric.Root.ObservableOrderItems.ElementAdded += (aList, aIdx) => { 
				FixPrice (aIdx [0]); 			
				enumPaymentType.Sensitive = UoWGeneric.Root.CanChangePaymentType ();
			};

			UoWGeneric.Root.ObservableOrderItems.ListContentChanged += (sender, e) => {
				UpdateSum ();
				enumPaymentType.Sensitive = UoWGeneric.Root.CanChangePaymentType ();
			};

			UoWGeneric.Root.ObservableOrderDepositItems.ListContentChanged += (sender, e) => {
				UpdateSum ();
				enumPaymentType.Sensitive = UoWGeneric.Root.CanChangePaymentType ();
			};

			UoWGeneric.Root.ObservableFinalOrderService.ElementAdded += (aList, aIdx) => {
				enumPaymentType.Sensitive = UoWGeneric.Root.CanChangePaymentType ();
				UpdateSum ();
			};
			
			UoWGeneric.Root.ObservableOrderDepositItems.ElementAdded += (aList, aIdx) => {
				enumPaymentType.Sensitive = UoWGeneric.Root.CanChangePaymentType ();
				UpdateSum ();
			};

			treeItems.Selection.Changed += TreeItems_Selection_Changed;
			#endregion
			dataSumDifferenceReason.Binding.AddBinding (Entity, s => s.SumDifferenceReason, w => w.Text).InitializeFromSource ();
			dataSumDifferenceReason.Completion = new EntryCompletion ();
			dataSumDifferenceReason.Completion.Model = OrderRepository.GetListStoreSumDifferenceReasons (UoWGeneric);
			dataSumDifferenceReason.Completion.TextColumn = 0;

			spinSumDifference.Value = (double)(UoWGeneric.Root.SumToReceive - UoWGeneric.Root.TotalSum);

			var colorBlack = new Gdk.Color (0, 0, 0);
			var colorBlue = new Gdk.Color (0, 0, 0xff);

			treeItems.ColumnsConfig = ColumnsConfigFactory.Create<OrderItem> ()
				.AddColumn ("Номенклатура").SetDataProperty (node => node.NomenclatureString)
				.AddColumn ("Кол-во").AddNumericRenderer (node => node.Count)
				.Adjustment (new Adjustment (0, 0, 1000000, 1, 100, 0))
				.AddSetter ((c, node) => c.Digits = node.Nomenclature.Unit == null ? 0 : (uint)node.Nomenclature.Unit.Digits)
				.AddSetter ((c, node) => c.Editable = node.CanEditAmount)
				.WidthChars (10)
				.AddTextRenderer (node => node.Nomenclature.Unit == null ? String.Empty : node.Nomenclature.Unit.Name, false)
				.AddColumn ("Цена").AddNumericRenderer (node => node.Price).Digits (2)
				.Adjustment (new Adjustment (0, 0, 1000000, 1, 100, 0)).Editing (true)
				.AddSetter((c,node)=>c.ForegroundGdk = node.HasUserSpecifiedPrice() && Nomenclature.GetCategoriesWithEditablePrice().Contains(node.Nomenclature.Category) ? colorBlue: colorBlack)
				.AddSetter((c,node)=>c.Editable = Nomenclature.GetCategoriesWithEditablePrice().Contains(node.Nomenclature.Category))
				.AddTextRenderer (node => CurrencyWorks.CurrencyShortName, false)
				.AddColumn("В т.ч. НДС").AddTextRenderer(x => CurrencyWorks.GetShortCurrencyString (x.IncludeNDS))
				.AddColumn ("Сумма").AddTextRenderer (node => CurrencyWorks.GetShortCurrencyString (node.Price * node.Count))
				.AddColumn ("Доп. соглашение").SetDataProperty (node => node.AgreementString)
				.Finish ();

			treeEquipment.ColumnsConfig = ColumnsConfigFactory.Create<OrderEquipment> ()
				.AddColumn ("Наименование").SetDataProperty (node => node.NameString)
				.AddColumn ("Направление").SetDataProperty (node => node.DirectionString)
				.AddColumn ("Причина").SetDataProperty (node => node.ReasonString)
				.Finish ();

			treeDocuments.ColumnsConfig = ColumnsConfigFactory.Create<OrderDocument> ()
				.AddColumn ("Документ").SetDataProperty (node => node.Name)
				.AddColumn ("Дата").SetDataProperty (node => node.DocumentDate)
				.Finish ();

			treeDepositRefundItems.ColumnsConfig = ColumnsConfigFactory.Create<OrderDepositItem> ()
				.AddColumn ("Тип").SetDataProperty (node => node.DepositTypeString)
				.AddColumn ("Количество").AddNumericRenderer (node => node.Count)
				.AddColumn ("Цена").AddNumericRenderer (node => node.Deposit)
				.AddColumn ("Сумма").AddNumericRenderer (node => node.Total)
				.RowCells ().AddSetter<CellRendererText> ((c, n) => c.Visible = n.PaymentDirection == PaymentDirection.ToClient)
				.Finish ();

			treeServiceClaim.ColumnsConfig = ColumnsConfigFactory.Create<ServiceClaim> ()
				.AddColumn ("Статус заявки").SetDataProperty (node => node.Status.GetEnumTitle ())
				.AddColumn ("Номенклатура оборудования").SetDataProperty (node => node.Nomenclature != null ? node.Nomenclature.Name : "-")
				.AddColumn ("Серийный номер").SetDataProperty (node => node.Equipment != null ? node.Equipment.Serial : "-")
				.AddColumn ("Причина").SetDataProperty (node => node.Reason)
				.RowCells ().AddSetter<CellRendererText> ((c, n) => c.Foreground = n.RowColor)
				.Finish ();
			treeServiceClaim.Selection.Changed += TreeServiceClaim_Selection_Changed;
			
			UpdateSum ();

			enumPaymentType.Sensitive = UoWGeneric.Root.CanChangePaymentType ();

			if (UoWGeneric.Root.OrderStatus != OrderStatus.NewOrder)
				IsEditable ();
		}

		void Entity_UpdateClientCanChange (object aList, int[] aIdx)
		{
			referenceClient.Sensitive = Entity.CanChangeContractor ();
		}

		void TreeServiceClaim_Selection_Changed (object sender, EventArgs e)
		{
			buttonOpenServiceClaim.Sensitive = treeServiceClaim.Selection.CountSelectedRows() > 0;
		}

		void FixPrice (int id)
		{
			OrderItem item = UoWGeneric.Root.ObservableOrderItems [id];
			if (item.Nomenclature.Category == NomenclatureCategory.water) {
				UoWGeneric.Root.RecalcBottlesDeposits (UoWGeneric);
			}
			if ((item.Nomenclature.Category == NomenclatureCategory.deposit || item.Nomenclature.Category == NomenclatureCategory.rent)
			     && item.Price != 0)
				return;
			if(!item.HasUserSpecifiedPrice())
				item.Price = item.DefaultPrice;
		}

		void TreeItems_Selection_Changed (object sender, EventArgs e)
		{
			object[] items = treeItems.GetSelectedObjects ();

			buttonDelete.Sensitive = items.Length > 0 && ((items [0] as OrderItem).AdditionalAgreement == null || (items [0] as OrderItem).Nomenclature.Category == NomenclatureCategory.water);
		}

		public override bool Save ()
		{
			var valid = new QSValidator<Order> (UoWGeneric.Root);
			if (valid.RunDlgIfNotValid ((Window)this.Toplevel))
				return false;

			logger.Info ("Сохраняем заказ...");
			UoWGeneric.Save ();
			logger.Info ("Ok.");
			return true;
		}

		#region Toggle buttons

		protected void OnToggleInformationToggled (object sender, EventArgs e)
		{
			if (toggleInformation.Active)
				notebook1.CurrentPage = 0;
		}

		protected void OnToggleGoodsToggled (object sender, EventArgs e)
		{
			if (toggleGoods.Active)
				notebook1.CurrentPage = 1;
		}

		protected void OnToggleEquipmentToggled (object sender, EventArgs e)
		{
			if (toggleEquipment.Active)
				notebook1.CurrentPage = 2;
		}

		protected void OnToggleServiceToggled (object sender, EventArgs e)
		{
			if (toggleService.Active)
				notebook1.CurrentPage = 3;
		}

		protected void OnToggleDocumentsToggled (object sender, EventArgs e)
		{
			if (toggleDocuments.Active)
				notebook1.CurrentPage = 4;
		}

		#endregion

		protected void OnReferenceClientChanged (object sender, EventArgs e)
		{
			if (CurrentObjectChanged != null)
				CurrentObjectChanged(this, new CurrentObjectChangedArgs(referenceClient.Subject));
			if (UoWGeneric.Root.Client != null) {
				referenceDeliveryPoint.RepresentationModel = new ViewModel.ClientDeliveryPointsVM (UoW, Entity.Client);
				referenceDeliveryPoint.Sensitive = UoWGeneric.Root.OrderStatus == OrderStatus.NewOrder;
			} else {
				referenceDeliveryPoint.Sensitive = false;
			}
			UpdateProxyInfo ();
		}

		private void IsEditable (bool val = false)
		{
			referenceDeliverySchedule.Sensitive = referenceDeliveryPoint.Sensitive = 
				referenceClient.Sensitive = val;
			enumAddRentButton.Sensitive = enumSignatureType.Sensitive = enumStatus.Sensitive = 
				enumPaymentType.Sensitive = val ? Entity.CanChangePaymentType() : false;
			buttonAddDoneService.Sensitive = buttonAddServiceClaim.Sensitive = 
				buttonAddForSale.Sensitive = buttonFillComment.Sensitive = val;
			spinBottlesReturn.Sensitive = spinSumDifference.Sensitive = val;
			checkDelivered.Sensitive = checkSelfDelivery.Sensitive = val;
			textComments.Sensitive = val;
			pickerDeliveryDate.Sensitive = val;
			dataSumDifferenceReason.Sensitive = val;
			treeItems.Sensitive = val;
		}

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			Entity.RemoveItem (treeItems.GetSelectedObject () as OrderItem);
		}

		protected void OnButtonAddForSaleClicked (object sender, EventArgs e)
		{
			if (UoWGeneric.Root.Client == null)
			{
				MessageDialogWorks.RunWarningDialog("Для добавления товара на продажу должен быть выбран клиент.");
				return;
			}

			ReferenceRepresentation SelectDialog = new ReferenceRepresentation (new ViewModel.NomenclatureForSaleVM (UoWGeneric));
			SelectDialog.Mode = OrmReferenceMode.Select;
			SelectDialog.TabName = "Номенклатура на продажу";
			SelectDialog.ObjectSelected += NomenclatureForSaleSelected;
			TabParent.AddSlaveTab (this, SelectDialog);
		}

		void NomenclatureForSaleSelected(object sender, ReferenceRepresentationSelectedEventArgs e){					
			NomenclatureSelected (this, new OrmReferenceObjectSectedEventArgs (UoWGeneric.Session.Get<Nomenclature> (e.ObjectId)));
		}

		void NomenclatureSelected (object sender, OrmReferenceObjectSectedEventArgs e)
		{
			Nomenclature nomenclature = e.Subject as Nomenclature;
			if (nomenclature.Category == NomenclatureCategory.additional || nomenclature.Category == NomenclatureCategory.bottle){
				UoWGeneric.Root.AddAnyGoodsNomenclatureForSale(nomenclature);
			} else if (nomenclature.Category == NomenclatureCategory.disposableBottleWater){
				UoWGeneric.Root.AddDisposableBottleWater(nomenclature);
			} else if (nomenclature.Category == NomenclatureCategory.equipment) {
				UoWGeneric.Root.AddEquipmentNomenclatureForSale (nomenclature, UoWGeneric);
			} else if (nomenclature.Category == NomenclatureCategory.water) {
				CounterpartyContract contract = CounterpartyContractRepository.
					GetCounterpartyContractByPaymentType (UoWGeneric, UoWGeneric.Root.Client, UoWGeneric.Root.PaymentType);
				if (contract == null) {
					var result = AskCreateContract ();
					switch (result) {
					case (int)ResponseType.Yes:
						RunContractAndWaterAgreementDialog ();
						break;
					case (int)ResponseType.Accept:
						CreateDefaultContractWithAgreement ();
						break;
					default:
						break;
					}
					return;
				}
				UoWGeneric.Session.Refresh (contract);
				WaterSalesAgreement wsa = contract.GetWaterSalesAgreement (UoWGeneric.Root.DeliveryPoint);
				if (wsa == null) {	
					//Если нет доп. соглашения продажи воды.
					if (MessageDialogWorks.RunQuestionDialog ("Отсутствует доп. соглашение с клиентом для продажи воды. Создать?")) {
						RunAdditionalAgreementWaterDialog ();
					} else
						return;
				} else {
					UoWGeneric.Root.AddWaterForSale (nomenclature, wsa);
					UoWGeneric.Root.RecalcBottlesDeposits (UoWGeneric);
				}
			}
			UpdateSum ();
		}

		private void AddRentAgreement (OrderAgreementType type)
		{
			ITdiDialog dlg;

			if (UoWGeneric.Root.Client == null || UoWGeneric.Root.DeliveryPoint == null) {
				MessageDialogWorks.RunWarningDialog ("Для добавления оборудования должна быть выбрана точка доставки.");
				return;
			}
			CounterpartyContract contract = CounterpartyContractRepository.GetCounterpartyContractByPaymentType (UoWGeneric, UoWGeneric.Root.Client, UoWGeneric.Root.PaymentType);
			if (contract == null) {
				RunContractCreateDialog ();
				return;
			} 
			switch (type) {
			case OrderAgreementType.NonfreeRent:
				dlg = new NonFreeRentAgreementDlg (contract, UoWGeneric.Root.DeliveryPoint, UoWGeneric.Root.DeliveryDate);
				break;
			case OrderAgreementType.DailyRent:
				dlg = new DailyRentAgreementDlg (contract, UoWGeneric.Root.DeliveryPoint, UoWGeneric.Root.DeliveryDate);
				break;
			default: 
				dlg = new FreeRentAgreementDlg (contract, UoWGeneric.Root.DeliveryPoint, UoWGeneric.Root.DeliveryDate);
				break;
			}
			(dlg as IAgreementSaved).AgreementSaved += AgreementSaved;
			TabParent.AddSlaveTab (this, dlg);
		}

		void AgreementSaved (object sender, AgreementSavedEventArgs e)
		{
			var agreement = UoWGeneric.Session.Merge(e.Agreement);
			UoWGeneric.Root.ObservableOrderDocuments.Add (new OrderAgreement { 
				Order = UoWGeneric.Root,
				AdditionalAgreement = agreement
			});
			UoWGeneric.Root.FillItemsFromAgreement (agreement);
			UpdateSum ();
			CounterpartyContractRepository.GetCounterpartyContractByPaymentType (UoWGeneric, UoWGeneric.Root.Client, UoWGeneric.Root.PaymentType).AdditionalAgreements.Add (agreement);
		}

		void UpdateSum ()
		{
			Decimal sum = UoWGeneric.Root.TotalSum;
			labelSum.Text = CurrencyWorks.GetShortCurrencyString (sum);
			UoWGeneric.Root.SumToReceive = sum + (Decimal)spinSumDifference.Value;
			labelSumTotal.Text = CurrencyWorks.GetShortCurrencyString (UoWGeneric.Root.SumToReceive);
		}

		protected void OnButtonViewDocumentClicked (object sender, EventArgs e)
		{
			if (treeDocuments.GetSelectedObjects ().GetLength (0) > 0) {
				ITdiDialog dlg = null;
				if (treeDocuments.GetSelectedObjects () [0] is OrderAgreement) {
					var agreement = (treeDocuments.GetSelectedObjects () [0] as OrderAgreement).AdditionalAgreement;
					var type = NHibernateProxyHelper.GuessClass(agreement);
					TabParent.OpenTab(
						OrmMain.GenerateDialogHashName(type, agreement.Id),
						() => OrmMain.CreateObjectDialog(type, agreement.Id)
					);
				} else if (treeDocuments.GetSelectedObjects () [0] is OrderContract) {
					var contract = (treeDocuments.GetSelectedObjects () [0] as OrderContract).Contract;
					dlg = OrmMain.CreateObjectDialog (contract);
				}

				if (dlg != null) {
					(dlg as IEditableDialog).IsEditable = false;
					TabParent.AddSlaveTab (this, dlg);
				}
			}

			var selectedPrintableDocuments = treeDocuments.GetSelectedObjects().Cast<OrderDocument>()
				.Where(doc => doc.PrintType != PrinterType.None).ToList();
			if (selectedPrintableDocuments.Count > 0)
			{
				string whatToPrint = selectedPrintableDocuments.Count > 1 
					? "документов" 
					: "документа \""+selectedPrintableDocuments.First().Type.GetEnumTitle()+"\"";
				if (UoWGeneric.HasChanges && CommonDialogs.SaveBeforePrint(typeof(Order), whatToPrint))
					UoWGeneric.Save();								
				selectedPrintableDocuments.ForEach(
					doc => TabParent.AddTab(DocumentPrinter.GetPreviewTab(doc), this, false)
				);
			}
		}

		protected void OnButtonFillCommentClicked (object sender, EventArgs e)
		{
			OrmReference SelectDialog = new OrmReference (typeof(CommentTemplate), UoWGeneric);
			SelectDialog.Mode = OrmReferenceMode.Select;
			SelectDialog.ButtonMode = ReferenceButtonMode.CanAdd;
			SelectDialog.ObjectSelected += (s, ea) => {
				if (ea.Subject != null) {
					UoWGeneric.Root.Comment = (ea.Subject as CommentTemplate).Comment;
				}
			};
			TabParent.AddSlaveTab (this, SelectDialog);
		}

		protected void OnSpinSumDifferenceValueChanged (object sender, EventArgs e)
		{
			UpdateSum ();
			string text;
			if (spinSumDifference.Value > 0)
				text = "Сумма <b>переплаты</b>/недоплаты:";
			else if (spinSumDifference.Value < 0)
				text = "Сумма переплаты/<b>недоплаты</b>:";
			else
				text = "Сумма переплаты/недоплаты:";
			labelSumDifference.Markup = text;
		}

		void RunContractCreateDialog ()
		{
			ITdiTab dlg;
			var response = AskCreateContract ();
			if (response == (int)ResponseType.Yes) {
				dlg = new CounterpartyContractDlg (UoWGeneric.Root.Client, 
					OrganizationRepository.GetOrganizationByPaymentType (UoWGeneric, UoWGeneric.Root.PaymentType),
					UoWGeneric.Root.DeliveryDate);
				(dlg as IContractSaved).ContractSaved += OnContractSaved;
				TabParent.AddSlaveTab (this, dlg);
			} else if (response == (int)ResponseType.Accept) {
				var contract = CreateDefaultContract ();
				AddContractDocument (contract);
				Entity.Contract = contract;
			}
		}

		protected int AskCreateContract(){
			MessageDialog md = new MessageDialog (null,
				DialogFlags.Modal,
				MessageType.Question,
				ButtonsType.YesNo,
				"Отсутствует договор с клиентом для " +
				(UoWGeneric.Root.PaymentType == PaymentType.cash ? "наличной" : "безналичной") +
				" формы оплаты. Создать?");
			md.SetPosition (WindowPosition.Center);
			md.AddButton ("Автоматически", ResponseType.Accept);
			md.ShowAll ();
			var result = md.Run ();
			md.Destroy ();
			return result;
		}

		protected void RunContractAndWaterAgreementDialog(){
			ITdiTab dlg = new CounterpartyContractDlg (UoWGeneric.Root.Client,
				              OrganizationRepository.GetOrganizationByPaymentType (UoWGeneric, UoWGeneric.Root.PaymentType),
				              UoWGeneric.Root.DeliveryDate);
			(dlg as IContractSaved).ContractSaved += OnContractSaved;
			dlg.CloseTab += (sender, e) => {
				CounterpartyContract contract =
					CounterpartyContractRepository.GetCounterpartyContractByPaymentType (
						UoWGeneric,
						UoWGeneric.Root.Client,
						UoWGeneric.Root.PaymentType);
				if(contract!=null){
					bool hasWaterAgreement = contract.GetWaterSalesAgreement (UoWGeneric.Root.DeliveryPoint)!=null;
					if(!hasWaterAgreement)
						RunAdditionalAgreementWaterDialog();
				}
			};
			TabParent.AddSlaveTab (this, dlg);
		}

		protected void OnContractSaved(object sender, ContractSavedEventArgs args){
			UoWGeneric.Root.ObservableOrderDocuments.Add (new OrderContract { 
				Order = UoWGeneric.Root,
				Contract = args.Contract
			});
			Entity.Contract = args.Contract;
		}

		protected void RunAdditionalAgreementWaterDialog(){
			ITdiDialog dlg = new WaterAgreementDlg (CounterpartyContractRepository.GetCounterpartyContractByPaymentType (UoWGeneric, UoWGeneric.Root.Client, UoWGeneric.Root.PaymentType), UoWGeneric.Root.DeliveryDate);
			(dlg as IAgreementSaved).AgreementSaved += AgreementSaved;
			TabParent.AddSlaveTab (this, dlg);
		}

		protected void CreateDefaultContractWithAgreement(){
			var contract = CreateDefaultContract ();
			Entity.Contract = contract;
			AddContractDocument (contract);
			AdditionalAgreement agreement = contract.GetWaterSalesAgreement (UoWGeneric.Root.DeliveryPoint);
			if(agreement==null){
				agreement = CreateDefaultWaterAgreement (contract);
				contract.AdditionalAgreements.Add (agreement);
				AddAgreementDocument (agreement);
			}
		}			

		protected CounterpartyContract CreateDefaultContract(){
			CounterpartyContract result;
			using (var uow = CounterpartyContract.Create (UoWGeneric.Root.Client)) {
				var contract = uow.Root;
				contract.Organization = OrganizationRepository
					.GetOrganizationByPaymentType (UoWGeneric, UoWGeneric.Root.PaymentType);
				contract.IsArchive = false;
				if(UoWGeneric.Root.DeliveryDate.HasValue)
					contract.IssueDate = UoWGeneric.Root.DeliveryDate.Value;
				contract.AdditionalAgreements = new List<AdditionalAgreement> ();
				uow.Save ();
				result = uow.Root;
			}
			return result;
		}

		protected AdditionalAgreement CreateDefaultWaterAgreement(CounterpartyContract contract){
			AdditionalAgreement result;
			using (var uow = WaterSalesAgreement.Create (contract)) {
				AdditionalAgreement agreement = uow.Root;
				agreement.Contract = contract;
				agreement.AgreementNumber = WaterSalesAgreement.GetNumber (contract);
				if (UoWGeneric.Root.DeliveryDate.HasValue)
				{
					agreement.IssueDate = UoWGeneric.Root.DeliveryDate.Value;
					agreement.StartDate = UoWGeneric.Root.DeliveryDate.Value;
				}
				result = uow.Root;
				uow.Save ();
			}
			return result;
		}
			
		protected void AddContractDocument(CounterpartyContract contract){
			Order order = UoWGeneric.Root;
			var orderDocuments = UoWGeneric.Root.ObservableOrderDocuments;
			orderDocuments.Add (new OrderContract { 
				Order = order,
				Contract = contract
			});
		}

		protected void AddAgreementDocument(AdditionalAgreement agreement){
			Order order = UoWGeneric.Root;
			var orderDocuments = UoWGeneric.Root.ObservableOrderDocuments;
			orderDocuments.Add (new OrderAgreement { 
				Order = order,
				AdditionalAgreement = agreement
			});
		}
			
		protected void OnSpinBottlesReturnValueChanged (object sender, EventArgs e)
		{
			UoWGeneric.Root.RecalcBottlesDeposits (UoWGeneric);
		}

		protected void OnButtonAcceptClicked (object sender, EventArgs e)
		{
			if (UoWGeneric.Root.OrderStatus == OrderStatus.NewOrder) {
				var valid = new QSValidator<Order> (UoWGeneric.Root, 
					            new Dictionary<object, object> {
						{ "NewStatus", OrderStatus.Accepted }
					});
				if (valid.RunDlgIfNotValid ((Window)this.Toplevel))
					return;

				if (UoWGeneric.Root.BottlesReturn == 0 && Entity.OrderItems.Any (i => i.Nomenclature.Category == NomenclatureCategory.water)) {
					if (!MessageDialogWorks.RunQuestionDialog ("Указано нулевое количество бутылей на возврат. Вы действительно хотите продолжить?"))
						return;
				}

				foreach (OrderItem item in UoWGeneric.Root.ObservableOrderItems)
				{
					if (item.Nomenclature.Category == NomenclatureCategory.equipment && item.Nomenclature.Serial)
					{
						int[] alreadyAdded = UoWGeneric.Root.OrderEquipments
							.Where(orderEquipment => orderEquipment.Direction==Vodovoz.Domain.Orders.Direction.Deliver)
							.Where(orderEquipment => orderEquipment.Equipment!=null)
							.Select(orderEquipment => orderEquipment.Equipment.Id).ToArray();
						int equipmentCount = UoWGeneric.Root.OrderEquipments.Count(orderEquipment => orderEquipment?.Equipment?.Nomenclature?.Id == item.Nomenclature.Id);
						int equipmentToAddCount = item.Count - equipmentCount;
						var equipmentToAdd = EquipmentRepository.GetEquipmentForSaleByNomenclature(UoW, item.Nomenclature, equipmentToAddCount, alreadyAdded);
						for (int i = 0; i < equipmentToAddCount; i++)
						{
							UoWGeneric.Root.ObservableOrderEquipments.Add(new OrderEquipment
								{
									Order = UoWGeneric.Root,
									Direction = Vodovoz.Domain.Orders.Direction.Deliver,
									Equipment = equipmentToAdd[i],
									OrderItem = item,
									Reason = Reason.Sale
								});
						}
						for (; equipmentCount > item.Count; equipmentCount--)
						{
							UoWGeneric.Root.ObservableOrderEquipments.Remove(
								UoWGeneric.Root.ObservableOrderEquipments.Where(orderEquipment => orderEquipment.Reason == Reason.Sale && orderEquipment.Equipment.Nomenclature.Id == item.Nomenclature.Id).First()
							);
						}
					}						
				}

				UoWGeneric.Root.OrderStatus = OrderStatus.Accepted;
				UoWGeneric.Root.UpdateDocuments();

				treeItems.Selection.UnselectAll();
				treeEquipment.Selection.UnselectAll();
				treeDepositRefundItems.Selection.UnselectAll();
				UpdateButtonState();
				buttonSave.Click();
				return;
			}
			if (Entity.OrderStatus == OrderStatus.Accepted || Entity.OrderStatus == OrderStatus.Canceled) {
				Entity.ChangeStatus(OrderStatus.NewOrder);
				UpdateButtonState();
				return;
			}
		}

		void UpdateButtonState()
		{
			IsEditable (Entity.OrderStatus == OrderStatus.NewOrder );
			if(Entity.OrderStatus == OrderStatus.Accepted || Entity.OrderStatus == OrderStatus.Canceled)
			{
				var icon = new Image ();
				icon.Pixbuf = Stetic.IconLoader.LoadIcon (this, "gtk-edit", IconSize.Menu);
				buttonAccept.Image = icon;
				buttonAccept.Label = "Редактировать";
			}
			if(Entity.OrderStatus == OrderStatus.NewOrder)
			{
				var icon = new Image ();
				icon.Pixbuf = Stetic.IconLoader.LoadIcon (this, "gtk-edit", IconSize.Menu);
				buttonAccept.Image = icon;
				buttonAccept.Label = "Подтвердить";
			}

			buttonCancelOrder.Sensitive = Entity.OrderStatus == OrderStatus.Accepted || Entity.OrderStatus == OrderStatus.NewOrder;
		}

		protected void OnEnumSignatureTypeChanged (object sender, EventArgs e)
		{
			UpdateProxyInfo ();
		}

		void UpdateProxyInfo ()
		{
			labelProxyInfo.Visible = Entity.SignatureType == OrderSignatureType.ByProxy;
			if (Entity.SignatureType != OrderSignatureType.ByProxy)
				return;
			DBWorks.SQLHelper text = new DBWorks.SQLHelper ("");
			if (Entity.Client != null && Entity.DeliveryDate.HasValue) {
				var proxies = Entity.Client.Proxies.Where (p => p.IsActiveProxy (Entity.DeliveryDate.Value) && (p.DeliveryPoint == null || p.DeliveryPoint == Entity.DeliveryPoint));
				foreach (var proxy in proxies) {
					if (!String.IsNullOrWhiteSpace (text.Text))
						text.Add ("\n");
					text.Add (String.Format ("Доверенность{2} №{0} от {1:d}", proxy.Number, proxy.IssueDate, 
						proxy.DeliveryPoint == null ? "(общая)" : ""));
					text.StartNewList (": ");
					foreach (var pers in proxy.Persons) {
						text.AddAsList (pers.NameWithInitials);
					}
				}
			}
			if (String.IsNullOrWhiteSpace (text.Text))
				labelProxyInfo.Markup = "<span foreground=\"red\">Нет активной доверенности</span>";
			else
				labelProxyInfo.LabelProp = text.Text;
		}

		protected void OnReferenceDeliveryPointChanged (object sender, EventArgs e)
		{
			if (CurrentObjectChanged != null)
				CurrentObjectChanged(this, new CurrentObjectChangedArgs(referenceDeliveryPoint.Subject));
			UpdateProxyInfo ();
		}

		protected void OnButtonPrintSelectedClicked(object c, EventArgs args)
		{
			var selectedPrintableDocuments = treeDocuments.GetSelectedObjects().Cast<OrderDocument>()
				.Where(doc => doc.PrintType != PrinterType.None).ToList();
			if (selectedPrintableDocuments.Count > 0)
			{
				string whatToPrint = selectedPrintableDocuments.Count > 1 
					? "документов" 
					: "документа \""+selectedPrintableDocuments.First().Type.GetEnumTitle()+"\"";
				if (UoWGeneric.HasChanges && CommonDialogs.SaveBeforePrint(typeof(Order), whatToPrint))
					UoWGeneric.Save();
				DocumentPrinter.PrintAll(selectedPrintableDocuments);
			}
		}

		protected void OnTreeServiceClaimRowActivated (object o, RowActivatedArgs args)
		{
			ITdiTab mytab = TdiHelper.FindMyTab (this);
			if (mytab == null)
				return;

			ServiceClaimDlg dlg = new ServiceClaimDlg ((treeServiceClaim.GetSelectedObjects () [0] as ServiceClaim).Id);
			mytab.TabParent.AddSlaveTab (mytab, dlg);
		}

		protected void OnButtonAddServiceClaimClicked (object sender, EventArgs e)
		{
			if (!SaveOrderBeforeContinue ())
				return;
			var dlg = new ServiceClaimDlg (UoWGeneric.Root);
			TabParent.AddSlaveTab (this, dlg);
		}

		protected void OnButtonAddDoneServiceClicked (object sender, EventArgs e)
		{
			if (!SaveOrderBeforeContinue ())
				return;
			OrmReference SelectDialog = new OrmReference (typeof(ServiceClaim), UoWGeneric, 
				                            ServiceClaimRepository.GetDoneClaimsForClient (UoWGeneric.Root)
				.GetExecutableQueryOver (UoWGeneric.Session).RootCriteria);
			SelectDialog.Mode = OrmReferenceMode.Select;
			SelectDialog.ButtonMode = ReferenceButtonMode.CanEdit;
			SelectDialog.ObjectSelected += DoneServiceSelected;

			TabParent.AddSlaveTab (this, SelectDialog);
		}

		void DoneServiceSelected (object sender, OrmReferenceObjectSectedEventArgs e)
		{
			ServiceClaim selected = (e.Subject as ServiceClaim);
			var contract = CounterpartyContractRepository.GetCounterpartyContractByPaymentType (
				               UoWGeneric, 
				               UoWGeneric.Root.Client, 
				               UoWGeneric.Root.PaymentType);
			if (!contract.RepairAgreementExists ()) {
				RunAgreementCreateDialog (contract);
				return;
			}
			selected.FinalOrder = UoWGeneric.Root;
			UoWGeneric.Root.ObservableFinalOrderService.Add (selected);
			//TODO Add service nomenclature with price.
		}

		bool SaveOrderBeforeContinue ()
		{
			if (UoWGeneric.IsNew) {
				if (CommonDialogs.SaveBeforeCreateSlaveEntity (EntityObject.GetType (), typeof(ServiceClaim))) {
					if (!Save ())
						return false;
				} else
					return false;
			}
			return true;
		}

		void RunAgreementCreateDialog (CounterpartyContract contract)
		{
			ITdiTab dlg;
			string question = "Отсутствует доп. соглашение сервиса с клиентом в договоре для " +
			                  (UoWGeneric.Root.PaymentType == PaymentType.cash ? "наличной" : "безналичной") +
			                  " формы оплаты. Создать?";
			if (MessageDialogWorks.RunQuestionDialog (question)) {
				dlg = new RepairAgreementDlg (contract);
				(dlg as IAgreementSaved).AgreementSaved += (sender, e) => UoWGeneric.Root.ObservableOrderDocuments.Add (
					new OrderAgreement {
						Order = UoWGeneric.Root,
						AdditionalAgreement = e.Agreement
					});
				TabParent.AddSlaveTab (this, dlg);
			}
		}

		protected void OnEnumPaymentTypeChanged (object sender, EventArgs e)
		{
			enumSignatureType.Visible = checkDelivered.Visible = labelSignatureType.Visible = 
				(Entity.PaymentType == PaymentType.cashless);

			var org = OrganizationRepository.GetOrganizationByPaymentType (UoW , Entity.PaymentType);
			if((Entity.Contract == null || Entity.Contract.Organization.Id != org.Id) && Entity.Client != null)
				Entity.Contract = CounterpartyContractRepository.GetCounterpartyContractByPaymentType (UoWGeneric, Entity.Client, Entity.PaymentType);
		}

		protected void OnPickerDeliveryDateDateChanged (object sender, EventArgs e)
		{
			UpdateProxyInfo ();
		}

		protected void OnReferenceClientChangedByUser(object sender, EventArgs e)
		{
			if(Entity.DeliveryPoint == null && Entity.Client != null && Entity.Client.DeliveryPoints != null 
				&& Entity.OrderStatus == OrderStatus.NewOrder && !Entity.SelfDelivery
				&& Entity.Client.DeliveryPoints.Count == 1)
			{
				Entity.DeliveryPoint = Entity.Client.DeliveryPoints[0];
			}
		}

		protected void OnButtonOpenServiceClaimClicked(object sender, EventArgs e)
		{
			var claim = treeServiceClaim.GetSelectedObject<ServiceClaim>();
			OpenTab(
				OrmGtkDialogBase<ServiceClaim>.GenerateHashName(claim.Id),
				() => new ServiceClaimDlg(claim)
			);
		}

		protected void OnButtonCancelOrderClicked(object sender, EventArgs e)
		{
			var valid = new QSValidator<Order> (UoWGeneric.Root, 
				new Dictionary<object, object> {
				{ "NewStatus", OrderStatus.Canceled }
			});
			if (valid.RunDlgIfNotValid ((Window)this.Toplevel))
				return;
			
			Entity.ChangeStatus(OrderStatus.Canceled);
			UpdateButtonState();
		}
	}
}