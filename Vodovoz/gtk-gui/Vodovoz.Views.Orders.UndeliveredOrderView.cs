
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Orders
{
	public partial class UndeliveredOrderView
	{
		private global::Gtk.HBox hbox1;

		private global::Vodovoz.ViewWidgets.UndeliveredOrderCommentsView unOrderCmntView;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.VBox mainBox1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.VBox mainBox2;

		private global::Gtk.HBox hbox5;

		private global::Gtk.HBox hbxInProcessAtDepartment;

		private global::Gtk.Label lblInProcAtDep;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entrySubdivision;

		private global::Gtk.HBox hbxStatus;

		private global::Gtk.Label lblStatus;

		private global::Gamma.Widgets.yEnumComboBox yEnumCMBStatus;

		private global::Gtk.VBox vbxWithControls;

		private global::Gtk.HBox hbxUndelivery;

		private global::Gtk.Label lblUndeliveredOrder;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entryOrder;

		private global::Gtk.Table tblUndeliveryFields;

		private global::QS.Widgets.GtkUI.SpecialListComboBox comboProblemSource;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entryNewDeliverySchedule;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entryRegisteredByEmployee;

		private global::Gtk.Frame frame1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow4;

		private global::Gtk.Alignment GtkAlignment10;

		private global::Gtk.Label lblInfo;

		private global::Gtk.Label lblInfoCaption;

		private global::Vodovoz.ViewWidgets.GuiltyInUndeliveryView guiltyInUndeliveryView;

		private global::Gtk.HBox hbxForNewOrder;

		private global::Gtk.Label lblTransferDate;

		private global::Gtk.Button btnChooseOrder;

		private global::Gtk.Button btnNewOrder;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboboxTransferType;

		private global::Gtk.Label lblDispatcherCallTime;

		private global::Gtk.Label lblDriverCallPlace;

		private global::Gtk.Label lblDriverCallTime;

		private global::Gtk.Label lblGuilty;

		private global::Gtk.Label lblNewDeliverySchedule;

		private global::Gtk.Label lblRegisteredBy;

		private global::Gtk.Label lblTransferDateCaption;

		private global::QS.Widgets.GtkUI.DatePicker yDateDispatcherCallTime;

		private global::QS.Widgets.GtkUI.DatePicker yDateDriverCallTime;

		private global::Gamma.Widgets.yEnumComboBox yEnumCMBDriverCallPlace;

		private global::Gamma.GtkWidgets.yLabel ylabelProblemSource;

		private global::Gtk.VBox vbxReasonAndFines;

		private global::Gtk.Frame frame4;

		private global::Gtk.Alignment GtkAlignment11;

		private global::Gtk.ScrolledWindow GtkScrolledWindow5;

		private global::Gamma.GtkWidgets.yTextView txtReason;

		private global::Gtk.Label lblReason;

		private global::Gtk.Frame frame5;

		private global::Gtk.Alignment GtkAlignment12;

		private global::Gtk.ScrolledWindow GtkScrolledWindow6;

		private global::Gamma.GtkWidgets.yTreeView yTreeFines;

		private global::Gtk.Label lblFines;

		private global::Gtk.Button buttonAddFine;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Orders.UndeliveredOrderView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Orders.UndeliveredOrderView";
			// Container child Vodovoz.Views.Orders.UndeliveredOrderView.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.unOrderCmntView = new global::Vodovoz.ViewWidgets.UndeliveredOrderCommentsView();
			this.unOrderCmntView.Events = ((global::Gdk.EventMask)(256));
			this.unOrderCmntView.Name = "unOrderCmntView";
			this.hbox1.Add(this.unOrderCmntView);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.unOrderCmntView]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w2 = new global::Gtk.Viewport();
			w2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.mainBox1 = new global::Gtk.VBox();
			this.mainBox1.Name = "mainBox1";
			this.mainBox1.Spacing = 6;
			// Container child mainBox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w3;
			this.hbox4.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonSave]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w5 = new global::Gtk.Image();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w5;
			this.hbox4.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonCancel]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.mainBox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.mainBox1[this.hbox4]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child mainBox1.Gtk.Box+BoxChild
			this.mainBox2 = new global::Gtk.VBox();
			this.mainBox2.Name = "mainBox2";
			this.mainBox2.Spacing = 6;
			// Container child mainBox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbxInProcessAtDepartment = new global::Gtk.HBox();
			this.hbxInProcessAtDepartment.Name = "hbxInProcessAtDepartment";
			this.hbxInProcessAtDepartment.Spacing = 6;
			// Container child hbxInProcessAtDepartment.Gtk.Box+BoxChild
			this.lblInProcAtDep = new global::Gtk.Label();
			this.lblInProcAtDep.Name = "lblInProcAtDep";
			this.lblInProcAtDep.Xalign = 1F;
			this.lblInProcAtDep.LabelProp = global::Mono.Unix.Catalog.GetString("В работе у отдела:");
			this.hbxInProcessAtDepartment.Add(this.lblInProcAtDep);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbxInProcessAtDepartment[this.lblInProcAtDep]));
			w8.Position = 0;
			w8.Expand = false;
			// Container child hbxInProcessAtDepartment.Gtk.Box+BoxChild
			this.entrySubdivision = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entrySubdivision.Events = ((global::Gdk.EventMask)(256));
			this.entrySubdivision.Name = "entrySubdivision";
			this.entrySubdivision.CanEditReference = true;
			this.hbxInProcessAtDepartment.Add(this.entrySubdivision);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbxInProcessAtDepartment[this.entrySubdivision]));
			w9.Position = 1;
			this.hbox5.Add(this.hbxInProcessAtDepartment);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbxInProcessAtDepartment]));
			w10.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbxStatus = new global::Gtk.HBox();
			this.hbxStatus.Name = "hbxStatus";
			this.hbxStatus.Spacing = 6;
			// Container child hbxStatus.Gtk.Box+BoxChild
			this.lblStatus = new global::Gtk.Label();
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Xalign = 1F;
			this.lblStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Статус недовоза:");
			this.hbxStatus.Add(this.lblStatus);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbxStatus[this.lblStatus]));
			w11.Position = 0;
			w11.Expand = false;
			// Container child hbxStatus.Gtk.Box+BoxChild
			this.yEnumCMBStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.yEnumCMBStatus.Name = "yEnumCMBStatus";
			this.yEnumCMBStatus.ShowSpecialStateAll = false;
			this.yEnumCMBStatus.ShowSpecialStateNot = false;
			this.yEnumCMBStatus.UseShortTitle = false;
			this.yEnumCMBStatus.DefaultFirst = false;
			this.hbxStatus.Add(this.yEnumCMBStatus);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbxStatus[this.yEnumCMBStatus]));
			w12.Position = 1;
			this.hbox5.Add(this.hbxStatus);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbxStatus]));
			w13.Position = 1;
			this.mainBox2.Add(this.hbox5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.mainBox2[this.hbox5]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child mainBox2.Gtk.Box+BoxChild
			this.vbxWithControls = new global::Gtk.VBox();
			this.vbxWithControls.Name = "vbxWithControls";
			this.vbxWithControls.Spacing = 6;
			// Container child vbxWithControls.Gtk.Box+BoxChild
			this.hbxUndelivery = new global::Gtk.HBox();
			this.hbxUndelivery.Name = "hbxUndelivery";
			this.hbxUndelivery.Spacing = 6;
			// Container child hbxUndelivery.Gtk.Box+BoxChild
			this.lblUndeliveredOrder = new global::Gtk.Label();
			this.lblUndeliveredOrder.Name = "lblUndeliveredOrder";
			this.lblUndeliveredOrder.Xalign = 1F;
			this.lblUndeliveredOrder.LabelProp = global::Mono.Unix.Catalog.GetString("Недовоз:");
			this.hbxUndelivery.Add(this.lblUndeliveredOrder);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbxUndelivery[this.lblUndeliveredOrder]));
			w15.Position = 0;
			w15.Expand = false;
			// Container child hbxUndelivery.Gtk.Box+BoxChild
			this.entryOrder = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entryOrder.Events = ((global::Gdk.EventMask)(256));
			this.entryOrder.Name = "entryOrder";
			this.entryOrder.CanEditReference = true;
			this.hbxUndelivery.Add(this.entryOrder);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbxUndelivery[this.entryOrder]));
			w16.Position = 1;
			this.vbxWithControls.Add(this.hbxUndelivery);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbxWithControls[this.hbxUndelivery]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbxWithControls.Gtk.Box+BoxChild
			this.tblUndeliveryFields = new global::Gtk.Table(((uint)(8)), ((uint)(3)), false);
			this.tblUndeliveryFields.Name = "tblUndeliveryFields";
			this.tblUndeliveryFields.RowSpacing = ((uint)(6));
			this.tblUndeliveryFields.ColumnSpacing = ((uint)(6));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.comboProblemSource = new global::QS.Widgets.GtkUI.SpecialListComboBox();
			this.comboProblemSource.Name = "comboProblemSource";
			this.comboProblemSource.AddIfNotExist = false;
			this.comboProblemSource.DefaultFirst = false;
			this.comboProblemSource.ShowSpecialStateAll = false;
			this.comboProblemSource.ShowSpecialStateNot = false;
			this.tblUndeliveryFields.Add(this.comboProblemSource);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.comboProblemSource]));
			w18.TopAttach = ((uint)(7));
			w18.BottomAttach = ((uint)(8));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.entryNewDeliverySchedule = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entryNewDeliverySchedule.Events = ((global::Gdk.EventMask)(256));
			this.entryNewDeliverySchedule.Name = "entryNewDeliverySchedule";
			this.entryNewDeliverySchedule.CanEditReference = true;
			this.tblUndeliveryFields.Add(this.entryNewDeliverySchedule);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.entryNewDeliverySchedule]));
			w19.TopAttach = ((uint)(5));
			w19.BottomAttach = ((uint)(6));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.entryRegisteredByEmployee = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entryRegisteredByEmployee.Events = ((global::Gdk.EventMask)(256));
			this.entryRegisteredByEmployee.Name = "entryRegisteredByEmployee";
			this.entryRegisteredByEmployee.CanEditReference = true;
			this.tblUndeliveryFields.Add(this.entryRegisteredByEmployee);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.entryRegisteredByEmployee]));
			w20.TopAttach = ((uint)(6));
			w20.BottomAttach = ((uint)(7));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.BorderWidth = ((uint)(3));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			global::Gtk.Viewport w21 = new global::Gtk.Viewport();
			w21.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.GtkAlignment10 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment10.Name = "GtkAlignment10";
			this.GtkAlignment10.LeftPadding = ((uint)(12));
			// Container child GtkAlignment10.Gtk.Container+ContainerChild
			this.lblInfo = new global::Gtk.Label();
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Xalign = 0F;
			this.lblInfo.LabelProp = global::Mono.Unix.Catalog.GetString("<b>?</b>");
			this.lblInfo.UseMarkup = true;
			this.lblInfo.Selectable = true;
			this.GtkAlignment10.Add(this.lblInfo);
			w21.Add(this.GtkAlignment10);
			this.GtkScrolledWindow4.Add(w21);
			this.frame1.Add(this.GtkScrolledWindow4);
			this.lblInfoCaption = new global::Gtk.Label();
			this.lblInfoCaption.Name = "lblInfoCaption";
			this.lblInfoCaption.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Информация</b>");
			this.lblInfoCaption.UseMarkup = true;
			this.frame1.LabelWidget = this.lblInfoCaption;
			this.tblUndeliveryFields.Add(this.frame1);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.frame1]));
			w26.BottomAttach = ((uint)(8));
			w26.LeftAttach = ((uint)(2));
			w26.RightAttach = ((uint)(3));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.guiltyInUndeliveryView = new global::Vodovoz.ViewWidgets.GuiltyInUndeliveryView();
			this.guiltyInUndeliveryView.Events = ((global::Gdk.EventMask)(256));
			this.guiltyInUndeliveryView.Name = "guiltyInUndeliveryView";
			this.tblUndeliveryFields.Add(this.guiltyInUndeliveryView);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.guiltyInUndeliveryView]));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.hbxForNewOrder = new global::Gtk.HBox();
			this.hbxForNewOrder.Name = "hbxForNewOrder";
			this.hbxForNewOrder.Spacing = 6;
			// Container child hbxForNewOrder.Gtk.Box+BoxChild
			this.lblTransferDate = new global::Gtk.Label();
			this.lblTransferDate.Name = "lblTransferDate";
			this.lblTransferDate.LabelProp = global::Mono.Unix.Catalog.GetString("Заказ не\nсоздан ");
			this.lblTransferDate.Justify = ((global::Gtk.Justification)(2));
			this.hbxForNewOrder.Add(this.lblTransferDate);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbxForNewOrder[this.lblTransferDate]));
			w28.Position = 0;
			w28.Expand = false;
			// Container child hbxForNewOrder.Gtk.Box+BoxChild
			this.btnChooseOrder = new global::Gtk.Button();
			this.btnChooseOrder.CanFocus = true;
			this.btnChooseOrder.Name = "btnChooseOrder";
			this.btnChooseOrder.UseUnderline = true;
			this.btnChooseOrder.Label = global::Mono.Unix.Catalog.GetString("Выбрать заказ");
			this.hbxForNewOrder.Add(this.btnChooseOrder);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbxForNewOrder[this.btnChooseOrder]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbxForNewOrder.Gtk.Box+BoxChild
			this.btnNewOrder = new global::Gtk.Button();
			this.btnNewOrder.CanFocus = true;
			this.btnNewOrder.Name = "btnNewOrder";
			this.btnNewOrder.UseUnderline = true;
			this.btnNewOrder.Label = global::Mono.Unix.Catalog.GetString("Создать заказ");
			this.hbxForNewOrder.Add(this.btnNewOrder);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbxForNewOrder[this.btnNewOrder]));
			w30.Position = 2;
			w30.Expand = false;
			// Container child hbxForNewOrder.Gtk.Box+BoxChild
			this.yenumcomboboxTransferType = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboboxTransferType.Name = "yenumcomboboxTransferType";
			this.yenumcomboboxTransferType.ShowSpecialStateAll = false;
			this.yenumcomboboxTransferType.ShowSpecialStateNot = false;
			this.yenumcomboboxTransferType.UseShortTitle = false;
			this.yenumcomboboxTransferType.DefaultFirst = false;
			this.hbxForNewOrder.Add(this.yenumcomboboxTransferType);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbxForNewOrder[this.yenumcomboboxTransferType]));
			w31.Position = 3;
			w31.Expand = false;
			w31.Fill = false;
			this.tblUndeliveryFields.Add(this.hbxForNewOrder);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.hbxForNewOrder]));
			w32.TopAttach = ((uint)(4));
			w32.BottomAttach = ((uint)(5));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.lblDispatcherCallTime = new global::Gtk.Label();
			this.lblDispatcherCallTime.Name = "lblDispatcherCallTime";
			this.lblDispatcherCallTime.Xalign = 1F;
			this.lblDispatcherCallTime.LabelProp = global::Mono.Unix.Catalog.GetString("Время звонка клиенту:");
			this.tblUndeliveryFields.Add(this.lblDispatcherCallTime);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.lblDispatcherCallTime]));
			w33.TopAttach = ((uint)(3));
			w33.BottomAttach = ((uint)(4));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.lblDriverCallPlace = new global::Gtk.Label();
			this.lblDriverCallPlace.Name = "lblDriverCallPlace";
			this.lblDriverCallPlace.Xalign = 1F;
			this.lblDriverCallPlace.LabelProp = global::Mono.Unix.Catalog.GetString("Место звонка водителя:");
			this.tblUndeliveryFields.Add(this.lblDriverCallPlace);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.lblDriverCallPlace]));
			w34.TopAttach = ((uint)(1));
			w34.BottomAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.lblDriverCallTime = new global::Gtk.Label();
			this.lblDriverCallTime.Name = "lblDriverCallTime";
			this.lblDriverCallTime.Xalign = 1F;
			this.lblDriverCallTime.LabelProp = global::Mono.Unix.Catalog.GetString("Время звонка водителя:");
			this.tblUndeliveryFields.Add(this.lblDriverCallTime);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.lblDriverCallTime]));
			w35.TopAttach = ((uint)(2));
			w35.BottomAttach = ((uint)(3));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.lblGuilty = new global::Gtk.Label();
			this.lblGuilty.Name = "lblGuilty";
			this.lblGuilty.Xalign = 1F;
			this.lblGuilty.LabelProp = global::Mono.Unix.Catalog.GetString("Виновники:");
			this.tblUndeliveryFields.Add(this.lblGuilty);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.lblGuilty]));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.lblNewDeliverySchedule = new global::Gtk.Label();
			this.lblNewDeliverySchedule.Name = "lblNewDeliverySchedule";
			this.lblNewDeliverySchedule.Xalign = 1F;
			this.lblNewDeliverySchedule.LabelProp = global::Mono.Unix.Catalog.GetString("Новый интервал переноса:");
			this.tblUndeliveryFields.Add(this.lblNewDeliverySchedule);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.lblNewDeliverySchedule]));
			w37.TopAttach = ((uint)(5));
			w37.BottomAttach = ((uint)(6));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.lblRegisteredBy = new global::Gtk.Label();
			this.lblRegisteredBy.Name = "lblRegisteredBy";
			this.lblRegisteredBy.Xalign = 1F;
			this.lblRegisteredBy.LabelProp = global::Mono.Unix.Catalog.GetString("Зарегистрировал:");
			this.tblUndeliveryFields.Add(this.lblRegisteredBy);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.lblRegisteredBy]));
			w38.TopAttach = ((uint)(6));
			w38.BottomAttach = ((uint)(7));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.lblTransferDateCaption = new global::Gtk.Label();
			this.lblTransferDateCaption.Name = "lblTransferDateCaption";
			this.lblTransferDateCaption.Xalign = 1F;
			this.lblTransferDateCaption.LabelProp = global::Mono.Unix.Catalog.GetString("Дата переноса:");
			this.tblUndeliveryFields.Add(this.lblTransferDateCaption);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.lblTransferDateCaption]));
			w39.TopAttach = ((uint)(4));
			w39.BottomAttach = ((uint)(5));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.yDateDispatcherCallTime = new global::QS.Widgets.GtkUI.DatePicker();
			this.yDateDispatcherCallTime.Events = ((global::Gdk.EventMask)(256));
			this.yDateDispatcherCallTime.Name = "yDateDispatcherCallTime";
			this.yDateDispatcherCallTime.WithTime = true;
			this.yDateDispatcherCallTime.HideCalendarButton = false;
			this.yDateDispatcherCallTime.Date = new global::System.DateTime(0);
			this.yDateDispatcherCallTime.IsEditable = true;
			this.yDateDispatcherCallTime.AutoSeparation = true;
			this.tblUndeliveryFields.Add(this.yDateDispatcherCallTime);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.yDateDispatcherCallTime]));
			w40.TopAttach = ((uint)(3));
			w40.BottomAttach = ((uint)(4));
			w40.LeftAttach = ((uint)(1));
			w40.RightAttach = ((uint)(2));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.yDateDriverCallTime = new global::QS.Widgets.GtkUI.DatePicker();
			this.yDateDriverCallTime.Events = ((global::Gdk.EventMask)(256));
			this.yDateDriverCallTime.Name = "yDateDriverCallTime";
			this.yDateDriverCallTime.WithTime = true;
			this.yDateDriverCallTime.HideCalendarButton = false;
			this.yDateDriverCallTime.Date = new global::System.DateTime(0);
			this.yDateDriverCallTime.IsEditable = true;
			this.yDateDriverCallTime.AutoSeparation = true;
			this.tblUndeliveryFields.Add(this.yDateDriverCallTime);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.yDateDriverCallTime]));
			w41.TopAttach = ((uint)(2));
			w41.BottomAttach = ((uint)(3));
			w41.LeftAttach = ((uint)(1));
			w41.RightAttach = ((uint)(2));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.yEnumCMBDriverCallPlace = new global::Gamma.Widgets.yEnumComboBox();
			this.yEnumCMBDriverCallPlace.Name = "yEnumCMBDriverCallPlace";
			this.yEnumCMBDriverCallPlace.ShowSpecialStateAll = false;
			this.yEnumCMBDriverCallPlace.ShowSpecialStateNot = false;
			this.yEnumCMBDriverCallPlace.UseShortTitle = false;
			this.yEnumCMBDriverCallPlace.DefaultFirst = false;
			this.tblUndeliveryFields.Add(this.yEnumCMBDriverCallPlace);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.yEnumCMBDriverCallPlace]));
			w42.TopAttach = ((uint)(1));
			w42.BottomAttach = ((uint)(2));
			w42.LeftAttach = ((uint)(1));
			w42.RightAttach = ((uint)(2));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblUndeliveryFields.Gtk.Table+TableChild
			this.ylabelProblemSource = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelProblemSource.Name = "ylabelProblemSource";
			this.ylabelProblemSource.Xalign = 1F;
			this.ylabelProblemSource.LabelProp = global::Mono.Unix.Catalog.GetString("Источник проблемы:");
			this.tblUndeliveryFields.Add(this.ylabelProblemSource);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.tblUndeliveryFields[this.ylabelProblemSource]));
			w43.TopAttach = ((uint)(7));
			w43.BottomAttach = ((uint)(8));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbxWithControls.Add(this.tblUndeliveryFields);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbxWithControls[this.tblUndeliveryFields]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			// Container child vbxWithControls.Gtk.Box+BoxChild
			this.vbxReasonAndFines = new global::Gtk.VBox();
			this.vbxReasonAndFines.Name = "vbxReasonAndFines";
			this.vbxReasonAndFines.Spacing = 6;
			// Container child vbxReasonAndFines.Gtk.Box+BoxChild
			this.frame4 = new global::Gtk.Frame();
			this.frame4.Name = "frame4";
			this.frame4.BorderWidth = ((uint)(3));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment11 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment11.Name = "GtkAlignment11";
			this.GtkAlignment11.LeftPadding = ((uint)(12));
			// Container child GtkAlignment11.Gtk.Container+ContainerChild
			this.GtkScrolledWindow5 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow5.Name = "GtkScrolledWindow5";
			this.GtkScrolledWindow5.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow5.Gtk.Container+ContainerChild
			this.txtReason = new global::Gamma.GtkWidgets.yTextView();
			this.txtReason.CanFocus = true;
			this.txtReason.Name = "txtReason";
			this.txtReason.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow5.Add(this.txtReason);
			this.GtkAlignment11.Add(this.GtkScrolledWindow5);
			this.frame4.Add(this.GtkAlignment11);
			this.lblReason = new global::Gtk.Label();
			this.lblReason.Name = "lblReason";
			this.lblReason.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Что случилось?</b>");
			this.lblReason.UseMarkup = true;
			this.frame4.LabelWidget = this.lblReason;
			this.vbxReasonAndFines.Add(this.frame4);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbxReasonAndFines[this.frame4]));
			w48.Position = 0;
			// Container child vbxReasonAndFines.Gtk.Box+BoxChild
			this.frame5 = new global::Gtk.Frame();
			this.frame5.Name = "frame5";
			this.frame5.BorderWidth = ((uint)(3));
			// Container child frame5.Gtk.Container+ContainerChild
			this.GtkAlignment12 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment12.Name = "GtkAlignment12";
			this.GtkAlignment12.LeftPadding = ((uint)(12));
			// Container child GtkAlignment12.Gtk.Container+ContainerChild
			this.GtkScrolledWindow6 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow6.Name = "GtkScrolledWindow6";
			this.GtkScrolledWindow6.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow6.Gtk.Container+ContainerChild
			this.yTreeFines = new global::Gamma.GtkWidgets.yTreeView();
			this.yTreeFines.CanFocus = true;
			this.yTreeFines.Name = "yTreeFines";
			this.GtkScrolledWindow6.Add(this.yTreeFines);
			this.GtkAlignment12.Add(this.GtkScrolledWindow6);
			this.frame5.Add(this.GtkAlignment12);
			this.lblFines = new global::Gtk.Label();
			this.lblFines.Name = "lblFines";
			this.lblFines.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Штрафы</b>");
			this.lblFines.UseMarkup = true;
			this.frame5.LabelWidget = this.lblFines;
			this.vbxReasonAndFines.Add(this.frame5);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbxReasonAndFines[this.frame5]));
			w52.Position = 1;
			// Container child vbxReasonAndFines.Gtk.Box+BoxChild
			this.buttonAddFine = new global::Gtk.Button();
			this.buttonAddFine.CanFocus = true;
			this.buttonAddFine.Name = "buttonAddFine";
			this.buttonAddFine.UseUnderline = true;
			this.buttonAddFine.Label = global::Mono.Unix.Catalog.GetString("Добавить штраф");
			global::Gtk.Image w53 = new global::Gtk.Image();
			w53.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddFine.Image = w53;
			this.vbxReasonAndFines.Add(this.buttonAddFine);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbxReasonAndFines[this.buttonAddFine]));
			w54.PackType = ((global::Gtk.PackType)(1));
			w54.Position = 2;
			w54.Fill = false;
			this.vbxWithControls.Add(this.vbxReasonAndFines);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbxWithControls[this.vbxReasonAndFines]));
			w55.Position = 2;
			this.mainBox2.Add(this.vbxWithControls);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.mainBox2[this.vbxWithControls]));
			w56.Position = 1;
			this.mainBox1.Add(this.mainBox2);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.mainBox1[this.mainBox2]));
			w57.Position = 1;
			w2.Add(this.mainBox1);
			this.GtkScrolledWindow.Add(w2);
			this.hbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.GtkScrolledWindow]));
			w60.Position = 1;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.yenumcomboboxTransferType.Hide();
			this.Hide();
		}
	}
}
