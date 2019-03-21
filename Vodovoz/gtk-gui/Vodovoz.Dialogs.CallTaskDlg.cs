
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Dialogs
{
	public partial class CallTaskDlg
	{
		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Table table1;

		private global::QSContacts.PhonesView ClientPhonesview;

		private global::Gamma.Widgets.yDatePicker deadlineYdatepicker;

		private global::Gtk.Entry debtByAddressEntry;

		private global::Gamma.GtkWidgets.yEntry debtByClientEntry;

		private global::Gamma.Widgets.yEntryReferenceVM deliveryPointYentryreferencevm;

		private global::Gamma.Widgets.yEntryReferenceVM EmployeeyEntryreferencevm;

		private global::Gtk.Entry entryReserve;

		private global::Gamma.GtkWidgets.yCheckButton IsTaskCompleteButton;

		private global::Gtk.Label label1;

		private global::Gtk.Label label10;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gamma.Widgets.yEnumComboBox TaskStateComboBox;

		private global::Gamma.GtkWidgets.yEntry yentryCounterparty;

		private global::Gtk.VBox vboxComments;

		private global::Gtk.Label label9;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTextView ytextviewComments;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTextView textviewLastComment;

		private global::Gtk.Button buttonAddComment;

		private global::Gtk.Button buttonRevertComment;

		private global::Gtk.Button buttonSplit;

		private global::Gtk.VBox vboxOldComments;

		private global::Gtk.Label label11;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::Gamma.GtkWidgets.yTextView ytextviewOldComments;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button createOrderButton;

		private global::Gtk.Button createTaskButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Dialogs.CallTaskDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Dialogs.CallTaskDlg";
			// Container child Vodovoz.Dialogs.CallTaskDlg.Gtk.Container+ContainerChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 20;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w2 = new global::Gtk.Image();
			w2.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w2;
			this.hbox3.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonSave]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w4;
			this.hbox3.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonCancel]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox2.Add(this.hbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 15;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(10)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(10));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.ClientPhonesview = new global::QSContacts.PhonesView();
			this.ClientPhonesview.Events = ((global::Gdk.EventMask)(256));
			this.ClientPhonesview.Name = "ClientPhonesview";
			this.ClientPhonesview.IsReadOnly = false;
			this.table1.Add(this.ClientPhonesview);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.ClientPhonesview]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.deadlineYdatepicker = new global::Gamma.Widgets.yDatePicker();
			this.deadlineYdatepicker.Events = ((global::Gdk.EventMask)(256));
			this.deadlineYdatepicker.Name = "deadlineYdatepicker";
			this.deadlineYdatepicker.WithTime = true;
			this.deadlineYdatepicker.Date = new global::System.DateTime(0);
			this.deadlineYdatepicker.IsEditable = true;
			this.deadlineYdatepicker.AutoSeparation = false;
			this.table1.Add(this.deadlineYdatepicker);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.deadlineYdatepicker]));
			w8.TopAttach = ((uint)(7));
			w8.BottomAttach = ((uint)(8));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.debtByAddressEntry = new global::Gtk.Entry();
			this.debtByAddressEntry.CanFocus = true;
			this.debtByAddressEntry.Name = "debtByAddressEntry";
			this.debtByAddressEntry.IsEditable = false;
			this.debtByAddressEntry.InvisibleChar = '•';
			this.table1.Add(this.debtByAddressEntry);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.debtByAddressEntry]));
			w9.TopAttach = ((uint)(5));
			w9.BottomAttach = ((uint)(6));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.debtByClientEntry = new global::Gamma.GtkWidgets.yEntry();
			this.debtByClientEntry.CanFocus = true;
			this.debtByClientEntry.Name = "debtByClientEntry";
			this.debtByClientEntry.IsEditable = false;
			this.debtByClientEntry.InvisibleChar = '•';
			this.table1.Add(this.debtByClientEntry);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.debtByClientEntry]));
			w10.TopAttach = ((uint)(4));
			w10.BottomAttach = ((uint)(5));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.deliveryPointYentryreferencevm = new global::Gamma.Widgets.yEntryReferenceVM();
			this.deliveryPointYentryreferencevm.Events = ((global::Gdk.EventMask)(256));
			this.deliveryPointYentryreferencevm.Name = "deliveryPointYentryreferencevm";
			this.table1.Add(this.deliveryPointYentryreferencevm);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.deliveryPointYentryreferencevm]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.EmployeeyEntryreferencevm = new global::Gamma.Widgets.yEntryReferenceVM();
			this.EmployeeyEntryreferencevm.Events = ((global::Gdk.EventMask)(256));
			this.EmployeeyEntryreferencevm.Name = "EmployeeyEntryreferencevm";
			this.table1.Add(this.EmployeeyEntryreferencevm);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.EmployeeyEntryreferencevm]));
			w12.TopAttach = ((uint)(8));
			w12.BottomAttach = ((uint)(9));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryReserve = new global::Gtk.Entry();
			this.entryReserve.CanFocus = true;
			this.entryReserve.Name = "entryReserve";
			this.entryReserve.IsEditable = false;
			this.entryReserve.InvisibleChar = '•';
			this.table1.Add(this.entryReserve);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.entryReserve]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.IsTaskCompleteButton = new global::Gamma.GtkWidgets.yCheckButton();
			this.IsTaskCompleteButton.HeightRequest = 40;
			this.IsTaskCompleteButton.CanFocus = true;
			this.IsTaskCompleteButton.Name = "IsTaskCompleteButton";
			this.IsTaskCompleteButton.Label = global::Mono.Unix.Catalog.GetString("Задача выполнена");
			this.IsTaskCompleteButton.DrawIndicator = true;
			this.IsTaskCompleteButton.UseUnderline = true;
			this.table1.Add(this.IsTaskCompleteButton);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.IsTaskCompleteButton]));
			w14.TopAttach = ((uint)(9));
			w14.BottomAttach = ((uint)(10));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Клиент");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Резерв");
			this.table1.Add(this.label10);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.label10]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Адрес");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Телефон:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Долг по клиенту");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w19.TopAttach = ((uint)(4));
			w19.BottomAttach = ((uint)(5));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Долг по адресу");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w20.TopAttach = ((uint)(5));
			w20.BottomAttach = ((uint)(6));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Выполнить до");
			this.table1.Add(this.label6);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w21.TopAttach = ((uint)(7));
			w21.BottomAttach = ((uint)(8));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Статус задачи");
			this.table1.Add(this.label7);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w22.TopAttach = ((uint)(6));
			w22.BottomAttach = ((uint)(7));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Закреплено за");
			this.table1.Add(this.label8);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.label8]));
			w23.TopAttach = ((uint)(8));
			w23.BottomAttach = ((uint)(9));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.TaskStateComboBox = new global::Gamma.Widgets.yEnumComboBox();
			this.TaskStateComboBox.Name = "TaskStateComboBox";
			this.TaskStateComboBox.ShowSpecialStateAll = false;
			this.TaskStateComboBox.ShowSpecialStateNot = false;
			this.TaskStateComboBox.UseShortTitle = false;
			this.TaskStateComboBox.DefaultFirst = false;
			this.table1.Add(this.TaskStateComboBox);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.TaskStateComboBox]));
			w24.TopAttach = ((uint)(6));
			w24.BottomAttach = ((uint)(7));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryCounterparty = new global::Gamma.GtkWidgets.yEntry();
			this.yentryCounterparty.WidthRequest = 200;
			this.yentryCounterparty.CanFocus = true;
			this.yentryCounterparty.Name = "yentryCounterparty";
			this.yentryCounterparty.IsEditable = false;
			this.yentryCounterparty.InvisibleChar = '•';
			this.table1.Add(this.yentryCounterparty);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryCounterparty]));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vboxComments = new global::Gtk.VBox();
			this.vboxComments.Name = "vboxComments";
			this.vboxComments.Spacing = 6;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарий :");
			this.vboxComments.Add(this.label9);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.label9]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytextviewComments = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewComments.WidthRequest = 400;
			this.ytextviewComments.HeightRequest = 260;
			this.ytextviewComments.CanFocus = true;
			this.ytextviewComments.Name = "ytextviewComments";
			this.ytextviewComments.Editable = false;
			this.GtkScrolledWindow.Add(this.ytextviewComments);
			this.vboxComments.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.GtkScrolledWindow]));
			w29.Position = 1;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textviewLastComment = new global::Gamma.GtkWidgets.yTextView();
			this.textviewLastComment.HeightRequest = 150;
			this.textviewLastComment.CanFocus = true;
			this.textviewLastComment.Name = "textviewLastComment";
			this.GtkScrolledWindow1.Add(this.textviewLastComment);
			this.vboxComments.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.GtkScrolledWindow1]));
			w31.Position = 2;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.buttonAddComment = new global::Gtk.Button();
			this.buttonAddComment.CanFocus = true;
			this.buttonAddComment.Name = "buttonAddComment";
			this.buttonAddComment.UseUnderline = true;
			this.buttonAddComment.Label = global::Mono.Unix.Catalog.GetString("Добавить комментарий");
			global::Gtk.Image w32 = new global::Gtk.Image();
			w32.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddComment.Image = w32;
			this.vboxComments.Add(this.buttonAddComment);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.buttonAddComment]));
			w33.Position = 3;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.buttonRevertComment = new global::Gtk.Button();
			this.buttonRevertComment.CanFocus = true;
			this.buttonRevertComment.Name = "buttonRevertComment";
			this.buttonRevertComment.UseUnderline = true;
			this.buttonRevertComment.Label = global::Mono.Unix.Catalog.GetString("Отменить последний комментарий");
			global::Gtk.Image w34 = new global::Gtk.Image();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.buttonRevertComment.Image = w34;
			this.vboxComments.Add(this.buttonRevertComment);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.buttonRevertComment]));
			w35.Position = 4;
			w35.Expand = false;
			w35.Fill = false;
			this.hbox1.Add(this.vboxComments);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vboxComments]));
			w36.Position = 1;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSplit = new global::Gtk.Button();
			this.buttonSplit.WidthRequest = 30;
			this.buttonSplit.CanFocus = true;
			this.buttonSplit.Name = "buttonSplit";
			this.buttonSplit.UseUnderline = true;
			this.buttonSplit.Label = global::Mono.Unix.Catalog.GetString("<<");
			this.hbox1.Add(this.buttonSplit);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSplit]));
			w37.Position = 2;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vboxOldComments = new global::Gtk.VBox();
			this.vboxOldComments.Name = "vboxOldComments";
			this.vboxOldComments.Spacing = 6;
			// Container child vboxOldComments.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарии про прошлым задачам");
			this.vboxOldComments.Add(this.label11);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vboxOldComments[this.label11]));
			w38.Position = 0;
			w38.Expand = false;
			w38.Fill = false;
			// Container child vboxOldComments.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.ytextviewOldComments = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewOldComments.WidthRequest = 400;
			this.ytextviewOldComments.CanFocus = true;
			this.ytextviewOldComments.Name = "ytextviewOldComments";
			this.GtkScrolledWindow2.Add(this.ytextviewOldComments);
			this.vboxOldComments.Add(this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vboxOldComments[this.GtkScrolledWindow2]));
			w40.Position = 1;
			this.hbox1.Add(this.vboxOldComments);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vboxOldComments]));
			w41.Position = 3;
			w41.Expand = false;
			w41.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w42.Position = 1;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.createOrderButton = new global::Gtk.Button();
			this.createOrderButton.CanFocus = true;
			this.createOrderButton.Name = "createOrderButton";
			this.createOrderButton.UseUnderline = true;
			this.createOrderButton.Label = global::Mono.Unix.Catalog.GetString("Оформить заказ");
			this.hbox4.Add(this.createOrderButton);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.createOrderButton]));
			w43.Position = 0;
			w43.Expand = false;
			w43.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.createTaskButton = new global::Gtk.Button();
			this.createTaskButton.CanFocus = true;
			this.createTaskButton.Name = "createTaskButton";
			this.createTaskButton.UseUnderline = true;
			this.createTaskButton.Label = global::Mono.Unix.Catalog.GetString("Создать новую задачу");
			this.hbox4.Add(this.createTaskButton);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.createTaskButton]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w45.Position = 2;
			w45.Expand = false;
			w45.Fill = false;
			w1.Add(this.vbox2);
			this.scrolledwindow1.Add(w1);
			this.Add(this.scrolledwindow1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.vboxOldComments.Hide();
			this.Hide();
			this.buttonSave.Clicked += new global::System.EventHandler(this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.OnButtonCancelClicked);
			this.deliveryPointYentryreferencevm.ChangedByUser += new global::System.EventHandler(this.OnDeliveryPointYentryreferencevmChangedByUser);
			this.buttonAddComment.Clicked += new global::System.EventHandler(this.OnAddCommentButtonClicked);
			this.buttonRevertComment.Clicked += new global::System.EventHandler(this.OnCancelLastCommentButtonClicked);
			this.buttonSplit.Clicked += new global::System.EventHandler(this.OnButtonSplitClicked);
			this.createOrderButton.Clicked += new global::System.EventHandler(this.OnButtonCreateOrderClicked);
			this.createTaskButton.Clicked += new global::System.EventHandler(this.OnCreateTaskButtonClicked);
		}
	}
}
