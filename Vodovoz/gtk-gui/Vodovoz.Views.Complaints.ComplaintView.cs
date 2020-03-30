
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Complaints
{
	public partial class ComplaintView
	{
		private global::Gtk.HPaned hpaned1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow6;

		private global::Gtk.VBox vboxDicussions;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.VBox vboxComplaint;

		private global::Gtk.HBox hboxDialogButtons;

		private global::Gamma.GtkWidgets.yButton buttonSave;

		private global::Gamma.GtkWidgets.yButton buttonCancel;

		private global::Gtk.HBox hboxInfo;

		private global::Gamma.GtkWidgets.yLabel ylabelSubdivisions;

		private global::Gtk.VSeparator vseparator1;

		private global::Gamma.GtkWidgets.yLabel ylabelCreatedBy;

		private global::Gtk.VSeparator vseparator2;

		private global::Gamma.GtkWidgets.yLabel ylabelChangedBy;

		private global::Gtk.Table tableFields;

		private global::Gamma.Widgets.ySpecComboBox comboboxComplaintSource;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entryCounterparty;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entryOrder;

		private global::Vodovoz.Views.Complaints.GuiltyItemsView guiltyitemsview;

		private global::Gamma.GtkWidgets.yLabel labelCounterparty;

		private global::Gamma.GtkWidgets.yLabel labelName;

		private global::Gamma.GtkWidgets.yLabel labelName4;

		private global::Gamma.GtkWidgets.yLabel labelNameGuilties;

		private global::Gamma.GtkWidgets.yLabel labelNamePhone;

		private global::Gamma.GtkWidgets.yLabel labelOrder;

		private global::Gamma.GtkWidgets.yLabel labelSource;

		private global::Gamma.GtkWidgets.yLabel labelStatus;

		private global::Gamma.GtkWidgets.yLabel lblAddress;

		private global::QS.Widgets.GtkUI.SpecialListComboBox spLstAddress;

		private global::QS.Widgets.GtkUI.DatePicker ydatepickerPlannedCompletionDate;

		private global::Gamma.GtkWidgets.yEntry yentryName;

		private global::Gamma.GtkWidgets.yEntry yentryPhone;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboStatus;

		private global::Gtk.HBox hbox9;

		private global::Gamma.GtkWidgets.yLabel labelComplaintText;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::Gamma.GtkWidgets.yTextView ytextviewComplaintText;

		private global::Gtk.HBox hbxComplaintKind;

		private global::Gamma.GtkWidgets.yLabel lblComplaintKind;

		private global::QS.Widgets.GtkUI.SpecialListComboBox cmbComplaintKind;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HBox hbox7;

		private global::Gamma.GtkWidgets.yLabel labelResultText;

		private global::Gtk.ScrolledWindow GtkScrolledWindow3;

		private global::Gamma.GtkWidgets.yTextView ytextviewResultText;

		private global::Vodovoz.Views.Complaints.ComplaintFilesView complaintfilesview;

		private global::Gtk.HBox hboxArrangement;

		private global::Gamma.GtkWidgets.yLabel ylabelArrangement;

		private global::Gamma.GtkWidgets.yEntry yentryArrangement;

		private global::Gtk.HBox hbox8;

		private global::Gamma.GtkWidgets.yLabel labelResult;

		private global::Gamma.Widgets.ySpecComboBox comboboxComplaintResult;

		private global::Gtk.ScrolledWindow GtkScrolledWindow5;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewFines;

		private global::Gtk.HBox hboxFineButtons;

		private global::Gamma.GtkWidgets.yButton buttonAttachFine;

		private global::Gamma.GtkWidgets.yButton buttonAddFine;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Complaints.ComplaintView
			global::Stetic.BinContainer.Attach(this);
			this.WidthRequest = 800;
			this.Name = "Vodovoz.Views.Complaints.ComplaintView";
			// Container child Vodovoz.Views.Complaints.ComplaintView.Gtk.Container+ContainerChild
			this.hpaned1 = new global::Gtk.HPaned();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 512;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow6 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow6.Name = "GtkScrolledWindow6";
			this.GtkScrolledWindow6.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow6.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.vboxDicussions = new global::Gtk.VBox();
			this.vboxDicussions.WidthRequest = 450;
			this.vboxDicussions.Name = "vboxDicussions";
			this.vboxDicussions.Spacing = 6;
			w1.Add(this.vboxDicussions);
			this.GtkScrolledWindow6.Add(w1);
			this.hpaned1.Add(this.GtkScrolledWindow6);
			global::Gtk.Paned.PanedChild w4 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.GtkScrolledWindow6]));
			w4.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w5 = new global::Gtk.Viewport();
			w5.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vboxComplaint = new global::Gtk.VBox();
			this.vboxComplaint.Name = "vboxComplaint";
			this.vboxComplaint.Spacing = 6;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.hboxDialogButtons = new global::Gtk.HBox();
			this.hboxDialogButtons.Name = "hboxDialogButtons";
			this.hboxDialogButtons.Spacing = 6;
			// Container child hboxDialogButtons.Gtk.Box+BoxChild
			this.buttonSave = new global::Gamma.GtkWidgets.yButton();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w6 = new global::Gtk.Image();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w6;
			this.hboxDialogButtons.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxDialogButtons[this.buttonSave]));
			w7.Position = 0;
			w7.Expand = false;
			// Container child hboxDialogButtons.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gamma.GtkWidgets.yButton();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w8 = new global::Gtk.Image();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w8;
			this.hboxDialogButtons.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxDialogButtons[this.buttonCancel]));
			w9.Position = 1;
			w9.Expand = false;
			// Container child hboxDialogButtons.Gtk.Box+BoxChild
			this.hboxInfo = new global::Gtk.HBox();
			this.hboxInfo.Name = "hboxInfo";
			this.hboxInfo.Spacing = 6;
			// Container child hboxInfo.Gtk.Box+BoxChild
			this.ylabelSubdivisions = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelSubdivisions.Name = "ylabelSubdivisions";
			this.ylabelSubdivisions.LabelProp = global::Mono.Unix.Catalog.GetString("###");
			this.hboxInfo.Add(this.ylabelSubdivisions);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxInfo[this.ylabelSubdivisions]));
			w10.Position = 0;
			// Container child hboxInfo.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hboxInfo.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hboxInfo[this.vseparator1]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hboxInfo.Gtk.Box+BoxChild
			this.ylabelCreatedBy = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelCreatedBy.Name = "ylabelCreatedBy";
			this.ylabelCreatedBy.LabelProp = global::Mono.Unix.Catalog.GetString("###");
			this.hboxInfo.Add(this.ylabelCreatedBy);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hboxInfo[this.ylabelCreatedBy]));
			w12.Position = 2;
			// Container child hboxInfo.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.Name = "vseparator2";
			this.hboxInfo.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hboxInfo[this.vseparator2]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hboxInfo.Gtk.Box+BoxChild
			this.ylabelChangedBy = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelChangedBy.Name = "ylabelChangedBy";
			this.ylabelChangedBy.LabelProp = global::Mono.Unix.Catalog.GetString("###");
			this.hboxInfo.Add(this.ylabelChangedBy);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hboxInfo[this.ylabelChangedBy]));
			w14.Position = 4;
			this.hboxDialogButtons.Add(this.hboxInfo);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hboxDialogButtons[this.hboxInfo]));
			w15.PackType = ((global::Gtk.PackType)(1));
			w15.Position = 3;
			w15.Expand = false;
			this.vboxComplaint.Add(this.hboxDialogButtons);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.hboxDialogButtons]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.tableFields = new global::Gtk.Table(((uint)(6)), ((uint)(4)), false);
			this.tableFields.Name = "tableFields";
			this.tableFields.RowSpacing = ((uint)(6));
			this.tableFields.ColumnSpacing = ((uint)(6));
			// Container child tableFields.Gtk.Table+TableChild
			this.comboboxComplaintSource = new global::Gamma.Widgets.ySpecComboBox();
			this.comboboxComplaintSource.Name = "comboboxComplaintSource";
			this.comboboxComplaintSource.AddIfNotExist = false;
			this.comboboxComplaintSource.DefaultFirst = false;
			this.comboboxComplaintSource.ShowSpecialStateAll = false;
			this.comboboxComplaintSource.ShowSpecialStateNot = false;
			this.tableFields.Add(this.comboboxComplaintSource);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.tableFields[this.comboboxComplaintSource]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.LeftAttach = ((uint)(3));
			w17.RightAttach = ((uint)(4));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.entryCounterparty = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entryCounterparty.Events = ((global::Gdk.EventMask)(256));
			this.entryCounterparty.Name = "entryCounterparty";
			this.entryCounterparty.CanEditReference = false;
			this.tableFields.Add(this.entryCounterparty);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.tableFields[this.entryCounterparty]));
			w18.TopAttach = ((uint)(2));
			w18.BottomAttach = ((uint)(3));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.entryOrder = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entryOrder.Events = ((global::Gdk.EventMask)(256));
			this.entryOrder.Name = "entryOrder";
			this.entryOrder.CanEditReference = false;
			this.tableFields.Add(this.entryOrder);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.tableFields[this.entryOrder]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(3));
			w19.RightAttach = ((uint)(4));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.guiltyitemsview = new global::Vodovoz.Views.Complaints.GuiltyItemsView();
			this.guiltyitemsview.HeightRequest = 125;
			this.guiltyitemsview.Events = ((global::Gdk.EventMask)(256));
			this.guiltyitemsview.Name = "guiltyitemsview";
			this.tableFields.Add(this.guiltyitemsview);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.tableFields[this.guiltyitemsview]));
			w20.TopAttach = ((uint)(5));
			w20.BottomAttach = ((uint)(6));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelCounterparty = new global::Gamma.GtkWidgets.yLabel();
			this.labelCounterparty.Name = "labelCounterparty";
			this.labelCounterparty.Xalign = 1F;
			this.labelCounterparty.LabelProp = global::Mono.Unix.Catalog.GetString("Клиент:");
			this.tableFields.Add(this.labelCounterparty);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelCounterparty]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelName = new global::Gamma.GtkWidgets.yLabel();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 1F;
			this.labelName.LabelProp = global::Mono.Unix.Catalog.GetString("Имя:");
			this.tableFields.Add(this.labelName);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelName]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelName4 = new global::Gamma.GtkWidgets.yLabel();
			this.labelName4.Name = "labelName4";
			this.labelName4.Xalign = 1F;
			this.labelName4.LabelProp = global::Mono.Unix.Catalog.GetString("Дата план. завершения:");
			this.tableFields.Add(this.labelName4);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelName4]));
			w23.LeftAttach = ((uint)(2));
			w23.RightAttach = ((uint)(3));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelNameGuilties = new global::Gamma.GtkWidgets.yLabel();
			this.labelNameGuilties.Name = "labelNameGuilties";
			this.labelNameGuilties.Xalign = 1F;
			this.labelNameGuilties.LabelProp = global::Mono.Unix.Catalog.GetString("Виновники:");
			this.tableFields.Add(this.labelNameGuilties);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelNameGuilties]));
			w24.TopAttach = ((uint)(5));
			w24.BottomAttach = ((uint)(6));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelNamePhone = new global::Gamma.GtkWidgets.yLabel();
			this.labelNamePhone.Name = "labelNamePhone";
			this.labelNamePhone.Xalign = 1F;
			this.labelNamePhone.LabelProp = global::Mono.Unix.Catalog.GetString("Телефон:");
			this.tableFields.Add(this.labelNamePhone);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelNamePhone]));
			w25.TopAttach = ((uint)(4));
			w25.BottomAttach = ((uint)(5));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelOrder = new global::Gamma.GtkWidgets.yLabel();
			this.labelOrder.Name = "labelOrder";
			this.labelOrder.Xalign = 1F;
			this.labelOrder.LabelProp = global::Mono.Unix.Catalog.GetString("Заказ:");
			this.tableFields.Add(this.labelOrder);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelOrder]));
			w26.TopAttach = ((uint)(2));
			w26.BottomAttach = ((uint)(3));
			w26.LeftAttach = ((uint)(2));
			w26.RightAttach = ((uint)(3));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelSource = new global::Gamma.GtkWidgets.yLabel();
			this.labelSource.Name = "labelSource";
			this.labelSource.Xalign = 1F;
			this.labelSource.LabelProp = global::Mono.Unix.Catalog.GetString("Источник:");
			this.tableFields.Add(this.labelSource);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelSource]));
			w27.TopAttach = ((uint)(4));
			w27.BottomAttach = ((uint)(5));
			w27.LeftAttach = ((uint)(2));
			w27.RightAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelStatus = new global::Gamma.GtkWidgets.yLabel();
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Xalign = 1F;
			this.labelStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Статус:");
			this.tableFields.Add(this.labelStatus);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelStatus]));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.lblAddress = new global::Gamma.GtkWidgets.yLabel();
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Xalign = 1F;
			this.lblAddress.LabelProp = global::Mono.Unix.Catalog.GetString("Адрес:");
			this.tableFields.Add(this.lblAddress);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.tableFields[this.lblAddress]));
			w29.TopAttach = ((uint)(3));
			w29.BottomAttach = ((uint)(4));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.spLstAddress = new global::QS.Widgets.GtkUI.SpecialListComboBox();
			this.spLstAddress.Name = "spLstAddress";
			this.spLstAddress.AddIfNotExist = false;
			this.spLstAddress.DefaultFirst = false;
			this.spLstAddress.ShowSpecialStateAll = false;
			this.spLstAddress.ShowSpecialStateNot = true;
			this.tableFields.Add(this.spLstAddress);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.tableFields[this.spLstAddress]));
			w30.TopAttach = ((uint)(3));
			w30.BottomAttach = ((uint)(4));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.ydatepickerPlannedCompletionDate = new global::QS.Widgets.GtkUI.DatePicker();
			this.ydatepickerPlannedCompletionDate.Events = ((global::Gdk.EventMask)(256));
			this.ydatepickerPlannedCompletionDate.Name = "ydatepickerPlannedCompletionDate";
			this.ydatepickerPlannedCompletionDate.WithTime = false;
			this.ydatepickerPlannedCompletionDate.HideCalendarButton = false;
			this.ydatepickerPlannedCompletionDate.Date = new global::System.DateTime(0);
			this.ydatepickerPlannedCompletionDate.IsEditable = true;
			this.ydatepickerPlannedCompletionDate.AutoSeparation = false;
			this.tableFields.Add(this.ydatepickerPlannedCompletionDate);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.tableFields[this.ydatepickerPlannedCompletionDate]));
			w31.LeftAttach = ((uint)(3));
			w31.RightAttach = ((uint)(4));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.yentryName = new global::Gamma.GtkWidgets.yEntry();
			this.yentryName.CanFocus = true;
			this.yentryName.Name = "yentryName";
			this.yentryName.IsEditable = true;
			this.yentryName.InvisibleChar = '●';
			this.tableFields.Add(this.yentryName);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.tableFields[this.yentryName]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(4));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.yentryPhone = new global::Gamma.GtkWidgets.yEntry();
			this.yentryPhone.CanFocus = true;
			this.yentryPhone.Name = "yentryPhone";
			this.yentryPhone.IsEditable = true;
			this.yentryPhone.InvisibleChar = '●';
			this.tableFields.Add(this.yentryPhone);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.tableFields[this.yentryPhone]));
			w33.TopAttach = ((uint)(4));
			w33.BottomAttach = ((uint)(5));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.yenumcomboStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboStatus.Name = "yenumcomboStatus";
			this.yenumcomboStatus.ShowSpecialStateAll = false;
			this.yenumcomboStatus.ShowSpecialStateNot = false;
			this.yenumcomboStatus.UseShortTitle = false;
			this.yenumcomboStatus.DefaultFirst = false;
			this.tableFields.Add(this.yenumcomboStatus);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.tableFields[this.yenumcomboStatus]));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vboxComplaint.Add(this.tableFields);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.tableFields]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.labelComplaintText = new global::Gamma.GtkWidgets.yLabel();
			this.labelComplaintText.Name = "labelComplaintText";
			this.labelComplaintText.Xalign = 0F;
			this.labelComplaintText.Yalign = 0F;
			this.labelComplaintText.LabelProp = global::Mono.Unix.Catalog.GetString("Проблема:       ");
			this.hbox9.Add(this.labelComplaintText);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.labelComplaintText]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.ytextviewComplaintText = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewComplaintText.CanFocus = true;
			this.ytextviewComplaintText.Name = "ytextviewComplaintText";
			this.ytextviewComplaintText.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow2.Add(this.ytextviewComplaintText);
			this.hbox9.Add(this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.GtkScrolledWindow2]));
			w38.Position = 1;
			this.vboxComplaint.Add(this.hbox9);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.hbox9]));
			w39.Position = 2;
			w39.Expand = false;
			w39.Fill = false;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.hbxComplaintKind = new global::Gtk.HBox();
			this.hbxComplaintKind.Name = "hbxComplaintKind";
			this.hbxComplaintKind.Spacing = 6;
			// Container child hbxComplaintKind.Gtk.Box+BoxChild
			this.lblComplaintKind = new global::Gamma.GtkWidgets.yLabel();
			this.lblComplaintKind.Name = "lblComplaintKind";
			this.lblComplaintKind.Xalign = 0F;
			this.lblComplaintKind.LabelProp = global::Mono.Unix.Catalog.GetString("Вид жалобы:  ");
			this.hbxComplaintKind.Add(this.lblComplaintKind);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbxComplaintKind[this.lblComplaintKind]));
			w40.Position = 0;
			w40.Expand = false;
			w40.Fill = false;
			// Container child hbxComplaintKind.Gtk.Box+BoxChild
			this.cmbComplaintKind = new global::QS.Widgets.GtkUI.SpecialListComboBox();
			this.cmbComplaintKind.Name = "cmbComplaintKind";
			this.cmbComplaintKind.AddIfNotExist = false;
			this.cmbComplaintKind.DefaultFirst = false;
			this.cmbComplaintKind.ShowSpecialStateAll = false;
			this.cmbComplaintKind.ShowSpecialStateNot = true;
			this.hbxComplaintKind.Add(this.cmbComplaintKind);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbxComplaintKind[this.cmbComplaintKind]));
			w41.Position = 1;
			this.vboxComplaint.Add(this.hbxComplaintKind);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.hbxComplaintKind]));
			w42.Position = 3;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vboxComplaint.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.hseparator1]));
			w43.Position = 4;
			w43.Expand = false;
			w43.Fill = false;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelResultText = new global::Gamma.GtkWidgets.yLabel();
			this.labelResultText.Name = "labelResultText";
			this.labelResultText.Xalign = 0F;
			this.labelResultText.Yalign = 0F;
			this.labelResultText.LabelProp = global::Mono.Unix.Catalog.GetString("Результат:        ");
			this.hbox7.Add(this.labelResultText);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.labelResultText]));
			w44.Position = 0;
			w44.Expand = false;
			w44.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.ytextviewResultText = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewResultText.CanFocus = true;
			this.ytextviewResultText.Name = "ytextviewResultText";
			this.ytextviewResultText.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow3.Add(this.ytextviewResultText);
			this.hbox7.Add(this.GtkScrolledWindow3);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.GtkScrolledWindow3]));
			w46.Position = 1;
			// Container child hbox7.Gtk.Box+BoxChild
			this.complaintfilesview = new global::Vodovoz.Views.Complaints.ComplaintFilesView();
			this.complaintfilesview.WidthRequest = 300;
			this.complaintfilesview.Events = ((global::Gdk.EventMask)(256));
			this.complaintfilesview.Name = "complaintfilesview";
			this.hbox7.Add(this.complaintfilesview);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.complaintfilesview]));
			w47.Position = 2;
			w47.Expand = false;
			w47.Fill = false;
			this.vboxComplaint.Add(this.hbox7);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.hbox7]));
			w48.Position = 5;
			w48.Expand = false;
			w48.Fill = false;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.hboxArrangement = new global::Gtk.HBox();
			this.hboxArrangement.Name = "hboxArrangement";
			this.hboxArrangement.Spacing = 6;
			// Container child hboxArrangement.Gtk.Box+BoxChild
			this.ylabelArrangement = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelArrangement.Name = "ylabelArrangement";
			this.ylabelArrangement.LabelProp = global::Mono.Unix.Catalog.GetString("Мероприятия:");
			this.hboxArrangement.Add(this.ylabelArrangement);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hboxArrangement[this.ylabelArrangement]));
			w49.Position = 0;
			w49.Expand = false;
			w49.Fill = false;
			// Container child hboxArrangement.Gtk.Box+BoxChild
			this.yentryArrangement = new global::Gamma.GtkWidgets.yEntry();
			this.yentryArrangement.CanFocus = true;
			this.yentryArrangement.Name = "yentryArrangement";
			this.yentryArrangement.IsEditable = true;
			this.yentryArrangement.MaxLength = 45;
			this.yentryArrangement.InvisibleChar = '•';
			this.hboxArrangement.Add(this.yentryArrangement);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hboxArrangement[this.yentryArrangement]));
			w50.Position = 1;
			this.vboxComplaint.Add(this.hboxArrangement);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.hboxArrangement]));
			w51.Position = 6;
			w51.Expand = false;
			w51.Fill = false;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.labelResult = new global::Gamma.GtkWidgets.yLabel();
			this.labelResult.Name = "labelResult";
			this.labelResult.LabelProp = global::Mono.Unix.Catalog.GetString("Итог работы:  ");
			this.hbox8.Add(this.labelResult);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.labelResult]));
			w52.Position = 0;
			w52.Expand = false;
			w52.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.comboboxComplaintResult = new global::Gamma.Widgets.ySpecComboBox();
			this.comboboxComplaintResult.Name = "comboboxComplaintResult";
			this.comboboxComplaintResult.AddIfNotExist = false;
			this.comboboxComplaintResult.DefaultFirst = false;
			this.comboboxComplaintResult.ShowSpecialStateAll = false;
			this.comboboxComplaintResult.ShowSpecialStateNot = false;
			this.hbox8.Add(this.comboboxComplaintResult);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.comboboxComplaintResult]));
			w53.Position = 1;
			w53.Expand = false;
			w53.Fill = false;
			this.vboxComplaint.Add(this.hbox8);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.hbox8]));
			w54.Position = 7;
			w54.Expand = false;
			w54.Fill = false;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.GtkScrolledWindow5 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow5.Name = "GtkScrolledWindow5";
			this.GtkScrolledWindow5.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow5.Gtk.Container+ContainerChild
			this.ytreeviewFines = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewFines.CanFocus = true;
			this.ytreeviewFines.Name = "ytreeviewFines";
			this.GtkScrolledWindow5.Add(this.ytreeviewFines);
			this.vboxComplaint.Add(this.GtkScrolledWindow5);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.GtkScrolledWindow5]));
			w56.Position = 8;
			// Container child vboxComplaint.Gtk.Box+BoxChild
			this.hboxFineButtons = new global::Gtk.HBox();
			this.hboxFineButtons.Name = "hboxFineButtons";
			this.hboxFineButtons.Spacing = 6;
			// Container child hboxFineButtons.Gtk.Box+BoxChild
			this.buttonAttachFine = new global::Gamma.GtkWidgets.yButton();
			this.buttonAttachFine.CanFocus = true;
			this.buttonAttachFine.Name = "buttonAttachFine";
			this.buttonAttachFine.UseUnderline = true;
			this.buttonAttachFine.Label = global::Mono.Unix.Catalog.GetString("Прикрепить штраф");
			this.hboxFineButtons.Add(this.buttonAttachFine);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.hboxFineButtons[this.buttonAttachFine]));
			w57.Position = 0;
			w57.Expand = false;
			w57.Fill = false;
			// Container child hboxFineButtons.Gtk.Box+BoxChild
			this.buttonAddFine = new global::Gamma.GtkWidgets.yButton();
			this.buttonAddFine.CanFocus = true;
			this.buttonAddFine.Name = "buttonAddFine";
			this.buttonAddFine.UseUnderline = true;
			this.buttonAddFine.Label = global::Mono.Unix.Catalog.GetString("Добавить штраф");
			this.hboxFineButtons.Add(this.buttonAddFine);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.hboxFineButtons[this.buttonAddFine]));
			w58.Position = 1;
			w58.Expand = false;
			w58.Fill = false;
			this.vboxComplaint.Add(this.hboxFineButtons);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vboxComplaint[this.hboxFineButtons]));
			w59.Position = 9;
			w59.Expand = false;
			w59.Fill = false;
			w5.Add(this.vboxComplaint);
			this.GtkScrolledWindow.Add(w5);
			this.hpaned1.Add(this.GtkScrolledWindow);
			this.Add(this.hpaned1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
