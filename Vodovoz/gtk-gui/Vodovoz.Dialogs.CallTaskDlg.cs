
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

		private global::Gtk.Label labelCreator;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Table table1;

		private global::QSContacts.PhonesView ClientPhonesview;

		private global::Gamma.Widgets.yEnumComboBox comboboxImpotanceType;

		private global::Gamma.Widgets.yDatePicker deadlineYdatepicker;

		private global::Gtk.Entry debtByAddressEntry;

		private global::Gamma.GtkWidgets.yEntry debtByClientEntry;

		private global::Gamma.Widgets.yEntryReferenceVM deliveryPointYentryreferencevm;

		private global::Gamma.Widgets.yEntryReferenceVM EmployeeyEntryreferencevm;

		private global::Gtk.Entry entryReserve;

		private global::Gamma.GtkWidgets.yCheckButton IsTaskCompleteButton;

		private global::Gtk.Label label1;

		private global::Gtk.Label label10;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gamma.Widgets.yEnumComboBox TaskStateComboBox;

		private global::Gamma.GtkWidgets.yEntry yentryCounterparty;

		private global::Gamma.Widgets.yValidatedEntry yentryTareReturn;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.VBox vboxComments;

		private global::Gtk.Label label9;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTextView ytextviewComments;

		private global::Gtk.HSeparator hseparator1;

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
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelCreator = new global::Gtk.Label();
			this.labelCreator.Name = "labelCreator";
			this.labelCreator.LabelProp = global::Mono.Unix.Catalog.GetString("Создатель :");
			this.hbox3.Add(this.labelCreator);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.labelCreator]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add(this.hbox3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 15;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(12)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(10));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.ClientPhonesview = new global::QSContacts.PhonesView();
			this.ClientPhonesview.Events = ((global::Gdk.EventMask)(256));
			this.ClientPhonesview.Name = "ClientPhonesview";
			this.ClientPhonesview.IsReadOnly = false;
			this.table1.Add(this.ClientPhonesview);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.ClientPhonesview]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxImpotanceType = new global::Gamma.Widgets.yEnumComboBox();
			this.comboboxImpotanceType.Name = "comboboxImpotanceType";
			this.comboboxImpotanceType.ShowSpecialStateAll = false;
			this.comboboxImpotanceType.ShowSpecialStateNot = false;
			this.comboboxImpotanceType.UseShortTitle = false;
			this.comboboxImpotanceType.DefaultFirst = false;
			this.table1.Add(this.comboboxImpotanceType);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxImpotanceType]));
			w9.TopAttach = ((uint)(10));
			w9.BottomAttach = ((uint)(11));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.deadlineYdatepicker = new global::Gamma.Widgets.yDatePicker();
			this.deadlineYdatepicker.Events = ((global::Gdk.EventMask)(256));
			this.deadlineYdatepicker.Name = "deadlineYdatepicker";
			this.deadlineYdatepicker.WithTime = true;
			this.deadlineYdatepicker.Date = new global::System.DateTime(0);
			this.deadlineYdatepicker.IsEditable = true;
			this.deadlineYdatepicker.AutoSeparation = false;
			this.table1.Add(this.deadlineYdatepicker);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.deadlineYdatepicker]));
			w10.TopAttach = ((uint)(7));
			w10.BottomAttach = ((uint)(8));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.debtByAddressEntry = new global::Gtk.Entry();
			this.debtByAddressEntry.CanFocus = true;
			this.debtByAddressEntry.Name = "debtByAddressEntry";
			this.debtByAddressEntry.IsEditable = false;
			this.debtByAddressEntry.InvisibleChar = '•';
			this.table1.Add(this.debtByAddressEntry);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.debtByAddressEntry]));
			w11.TopAttach = ((uint)(5));
			w11.BottomAttach = ((uint)(6));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.debtByClientEntry = new global::Gamma.GtkWidgets.yEntry();
			this.debtByClientEntry.CanFocus = true;
			this.debtByClientEntry.Name = "debtByClientEntry";
			this.debtByClientEntry.IsEditable = false;
			this.debtByClientEntry.InvisibleChar = '•';
			this.table1.Add(this.debtByClientEntry);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.debtByClientEntry]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.deliveryPointYentryreferencevm = new global::Gamma.Widgets.yEntryReferenceVM();
			this.deliveryPointYentryreferencevm.Events = ((global::Gdk.EventMask)(256));
			this.deliveryPointYentryreferencevm.Name = "deliveryPointYentryreferencevm";
			this.table1.Add(this.deliveryPointYentryreferencevm);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.deliveryPointYentryreferencevm]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.EmployeeyEntryreferencevm = new global::Gamma.Widgets.yEntryReferenceVM();
			this.EmployeeyEntryreferencevm.Events = ((global::Gdk.EventMask)(256));
			this.EmployeeyEntryreferencevm.Name = "EmployeeyEntryreferencevm";
			this.table1.Add(this.EmployeeyEntryreferencevm);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.EmployeeyEntryreferencevm]));
			w14.TopAttach = ((uint)(8));
			w14.BottomAttach = ((uint)(9));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryReserve = new global::Gtk.Entry();
			this.entryReserve.CanFocus = true;
			this.entryReserve.Name = "entryReserve";
			this.entryReserve.IsEditable = false;
			this.entryReserve.InvisibleChar = '•';
			this.table1.Add(this.entryReserve);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.entryReserve]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.IsTaskCompleteButton = new global::Gamma.GtkWidgets.yCheckButton();
			this.IsTaskCompleteButton.HeightRequest = 40;
			this.IsTaskCompleteButton.CanFocus = true;
			this.IsTaskCompleteButton.Name = "IsTaskCompleteButton";
			this.IsTaskCompleteButton.Label = global::Mono.Unix.Catalog.GetString("Задача выполнена ");
			this.IsTaskCompleteButton.DrawIndicator = true;
			this.IsTaskCompleteButton.UseUnderline = true;
			this.table1.Add(this.IsTaskCompleteButton);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.IsTaskCompleteButton]));
			w16.TopAttach = ((uint)(11));
			w16.BottomAttach = ((uint)(12));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Клиент");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Резерв");
			this.table1.Add(this.label10);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.label10]));
			w18.TopAttach = ((uint)(2));
			w18.BottomAttach = ((uint)(3));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Тара на забор :");
			this.table1.Add(this.label12);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.label12]));
			w19.TopAttach = ((uint)(9));
			w19.BottomAttach = ((uint)(10));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Срочность задачи");
			this.table1.Add(this.label13);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.label13]));
			w20.TopAttach = ((uint)(10));
			w20.BottomAttach = ((uint)(11));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Адрес");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Телефон:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w22.TopAttach = ((uint)(3));
			w22.BottomAttach = ((uint)(4));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Долг по клиенту");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w23.TopAttach = ((uint)(4));
			w23.BottomAttach = ((uint)(5));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Долг по адресу");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w24.TopAttach = ((uint)(5));
			w24.BottomAttach = ((uint)(6));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Выполнить до");
			this.table1.Add(this.label6);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w25.TopAttach = ((uint)(7));
			w25.BottomAttach = ((uint)(8));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Статус задачи");
			this.table1.Add(this.label7);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w26.TopAttach = ((uint)(6));
			w26.BottomAttach = ((uint)(7));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Закреплено за");
			this.table1.Add(this.label8);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1[this.label8]));
			w27.TopAttach = ((uint)(8));
			w27.BottomAttach = ((uint)(9));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.TaskStateComboBox = new global::Gamma.Widgets.yEnumComboBox();
			this.TaskStateComboBox.Name = "TaskStateComboBox";
			this.TaskStateComboBox.ShowSpecialStateAll = false;
			this.TaskStateComboBox.ShowSpecialStateNot = false;
			this.TaskStateComboBox.UseShortTitle = false;
			this.TaskStateComboBox.DefaultFirst = false;
			this.table1.Add(this.TaskStateComboBox);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1[this.TaskStateComboBox]));
			w28.TopAttach = ((uint)(6));
			w28.BottomAttach = ((uint)(7));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryCounterparty = new global::Gamma.GtkWidgets.yEntry();
			this.yentryCounterparty.WidthRequest = 200;
			this.yentryCounterparty.CanFocus = true;
			this.yentryCounterparty.Name = "yentryCounterparty";
			this.yentryCounterparty.IsEditable = false;
			this.yentryCounterparty.InvisibleChar = '•';
			this.table1.Add(this.yentryCounterparty);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryCounterparty]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryTareReturn = new global::Gamma.Widgets.yValidatedEntry();
			this.yentryTareReturn.CanFocus = true;
			this.yentryTareReturn.Name = "yentryTareReturn";
			this.yentryTareReturn.IsEditable = true;
			this.yentryTareReturn.InvisibleChar = '•';
			this.table1.Add(this.yentryTareReturn);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryTareReturn]));
			w30.TopAttach = ((uint)(9));
			w30.BottomAttach = ((uint)(10));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox1.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator1]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vboxComments = new global::Gtk.VBox();
			this.vboxComments.Name = "vboxComments";
			this.vboxComments.Spacing = 6;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарий :");
			this.vboxComments.Add(this.label9);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.label9]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytextviewComments = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewComments.CanFocus = true;
			this.ytextviewComments.Name = "ytextviewComments";
			this.ytextviewComments.Editable = false;
			this.ytextviewComments.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow.Add(this.ytextviewComments);
			this.vboxComments.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.GtkScrolledWindow]));
			w35.Position = 1;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vboxComments.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.hseparator1]));
			w36.Position = 2;
			w36.Expand = false;
			w36.Fill = false;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textviewLastComment = new global::Gamma.GtkWidgets.yTextView();
			this.textviewLastComment.CanFocus = true;
			this.textviewLastComment.Name = "textviewLastComment";
			this.GtkScrolledWindow1.Add(this.textviewLastComment);
			this.vboxComments.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.GtkScrolledWindow1]));
			w38.Position = 3;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.buttonAddComment = new global::Gtk.Button();
			this.buttonAddComment.CanFocus = true;
			this.buttonAddComment.Name = "buttonAddComment";
			this.buttonAddComment.UseUnderline = true;
			this.buttonAddComment.Label = global::Mono.Unix.Catalog.GetString("Добавить комментарий");
			global::Gtk.Image w39 = new global::Gtk.Image();
			w39.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddComment.Image = w39;
			this.vboxComments.Add(this.buttonAddComment);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.buttonAddComment]));
			w40.Position = 4;
			w40.Expand = false;
			w40.Fill = false;
			// Container child vboxComments.Gtk.Box+BoxChild
			this.buttonRevertComment = new global::Gtk.Button();
			this.buttonRevertComment.CanFocus = true;
			this.buttonRevertComment.Name = "buttonRevertComment";
			this.buttonRevertComment.UseUnderline = true;
			this.buttonRevertComment.Label = global::Mono.Unix.Catalog.GetString("Отменить последний комментарий");
			global::Gtk.Image w41 = new global::Gtk.Image();
			w41.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.buttonRevertComment.Image = w41;
			this.vboxComments.Add(this.buttonRevertComment);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vboxComments[this.buttonRevertComment]));
			w42.Position = 5;
			w42.Expand = false;
			w42.Fill = false;
			this.hbox1.Add(this.vboxComments);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vboxComments]));
			w43.Position = 2;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSplit = new global::Gtk.Button();
			this.buttonSplit.WidthRequest = 30;
			this.buttonSplit.CanFocus = true;
			this.buttonSplit.Name = "buttonSplit";
			this.buttonSplit.UseUnderline = true;
			this.buttonSplit.Label = global::Mono.Unix.Catalog.GetString(">>");
			this.hbox1.Add(this.buttonSplit);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSplit]));
			w44.Position = 3;
			w44.Expand = false;
			w44.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vboxOldComments = new global::Gtk.VBox();
			this.vboxOldComments.Name = "vboxOldComments";
			this.vboxOldComments.Spacing = 6;
			// Container child vboxOldComments.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарии про прошлым задачам");
			this.vboxOldComments.Add(this.label11);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vboxOldComments[this.label11]));
			w45.Position = 0;
			w45.Expand = false;
			w45.Fill = false;
			// Container child vboxOldComments.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.ytextviewOldComments = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewOldComments.CanFocus = true;
			this.ytextviewOldComments.Name = "ytextviewOldComments";
			this.ytextviewOldComments.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow2.Add(this.ytextviewOldComments);
			this.vboxOldComments.Add(this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vboxOldComments[this.GtkScrolledWindow2]));
			w47.Position = 1;
			this.hbox1.Add(this.vboxOldComments);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vboxOldComments]));
			w48.Position = 4;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w49.Position = 1;
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
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.createOrderButton]));
			w50.Position = 0;
			w50.Expand = false;
			w50.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.createTaskButton = new global::Gtk.Button();
			this.createTaskButton.CanFocus = true;
			this.createTaskButton.Name = "createTaskButton";
			this.createTaskButton.UseUnderline = true;
			this.createTaskButton.Label = global::Mono.Unix.Catalog.GetString("Создать новую задачу");
			this.hbox4.Add(this.createTaskButton);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.createTaskButton]));
			w51.Position = 1;
			w51.Expand = false;
			w51.Fill = false;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w52.Position = 2;
			w52.Expand = false;
			w52.Fill = false;
			w1.Add(this.vbox2);
			this.scrolledwindow1.Add(w1);
			this.Add(this.scrolledwindow1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.vboxOldComments.Hide();
			this.Hide();
			this.yentryTareReturn.Changed += new global::System.EventHandler(this.OnYentryTareReturnChanged);
			this.deliveryPointYentryreferencevm.ChangedByUser += new global::System.EventHandler(this.OnDeliveryPointYentryreferencevmChangedByUser);
			this.buttonAddComment.Clicked += new global::System.EventHandler(this.OnAddCommentButtonClicked);
			this.buttonRevertComment.Clicked += new global::System.EventHandler(this.OnCancelLastCommentButtonClicked);
			this.buttonSplit.Clicked += new global::System.EventHandler(this.OnButtonSplitClicked);
			this.createOrderButton.Clicked += new global::System.EventHandler(this.OnButtonCreateOrderClicked);
			this.createTaskButton.Clicked += new global::System.EventHandler(this.OnCreateTaskButtonClicked);
		}
	}
}
