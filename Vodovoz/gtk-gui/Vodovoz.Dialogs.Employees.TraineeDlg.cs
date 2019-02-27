
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Dialogs.Employees
{
	public partial class TraineeDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.RadioButton radioTabInfo;

		private global::Gtk.RadioButton radioTabAccounting;

		private global::Gtk.RadioButton radioTabFiles;

		private global::Gtk.RadioButton radioTabDocuments;

		private global::Gtk.Notebook notebookMain;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.Table datatableMain;

		private global::Gamma.GtkWidgets.yEntry dataentryDrivingNumber;

		private global::Gamma.GtkWidgets.yEntry dataentryLastName;

		private global::Gamma.GtkWidgets.yEntry dataentryName;

		private global::Gamma.GtkWidgets.yEntry dataentryPatronymic;

		private global::Gamma.GtkWidgets.yEntry entryAddressCurrent;

		private global::Gamma.GtkWidgets.yEntry entryAddressRegistration;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label14;

		private global::Gtk.Label label15;

		private global::Gtk.Label label2;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::QSContacts.PhonesView phonesView;

		private global::QS.Widgets.GtkUI.PhotoView photoviewEmployee;

		private global::Gamma.Widgets.yEntryReference referenceNationality;

		private global::Gtk.Label label1;

		private global::Gtk.VBox vbox5;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label19;

		private global::Gamma.GtkWidgets.yEntry entryInn;

		private global::QSBanks.AccountsView accountsView;

		private global::Gtk.Label label17;

		private global::QSAttachment.Attachment attachmentFiles;

		private global::Gtk.Label label24;

		private global::Gtk.VBox vbox6;

		private global::Gtk.HBox hbox12;

		private global::Gtk.Button button1;

		private global::Gtk.Button buttonDocumentEdit;

		private global::Gtk.Button button3;

		private global::Gtk.ScrolledWindow GtkScrolledWindow4;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewEmployeeDocument;

		private global::Gtk.Label label3;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Button buttonChangeToEmployee;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Dialogs.Employees.TraineeDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Dialogs.Employees.TraineeDlg";
			// Container child Vodovoz.Dialogs.Employees.TraineeDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox1.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox1.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator1]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radioTabInfo = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Основное"));
			this.radioTabInfo.CanFocus = true;
			this.radioTabInfo.Name = "radioTabInfo";
			this.radioTabInfo.DrawIndicator = false;
			this.radioTabInfo.UseUnderline = true;
			this.radioTabInfo.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox1.Add(this.radioTabInfo);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radioTabInfo]));
			w6.Position = 3;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radioTabAccounting = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Реквизиты"));
			this.radioTabAccounting.CanFocus = true;
			this.radioTabAccounting.Name = "radioTabAccounting";
			this.radioTabAccounting.DrawIndicator = false;
			this.radioTabAccounting.UseUnderline = true;
			this.radioTabAccounting.Group = this.radioTabInfo.Group;
			this.hbox1.Add(this.radioTabAccounting);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radioTabAccounting]));
			w7.Position = 4;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radioTabFiles = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Файлы"));
			this.radioTabFiles.CanFocus = true;
			this.radioTabFiles.Name = "radioTabFiles";
			this.radioTabFiles.DrawIndicator = false;
			this.radioTabFiles.UseUnderline = true;
			this.radioTabFiles.Group = this.radioTabInfo.Group;
			this.hbox1.Add(this.radioTabFiles);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radioTabFiles]));
			w8.Position = 5;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radioTabDocuments = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Документы"));
			this.radioTabDocuments.CanFocus = true;
			this.radioTabDocuments.Name = "radioTabDocuments";
			this.radioTabDocuments.DrawIndicator = false;
			this.radioTabDocuments.UseUnderline = true;
			this.radioTabDocuments.Group = this.radioTabInfo.Group;
			this.hbox1.Add(this.radioTabDocuments);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radioTabDocuments]));
			w9.Position = 6;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.notebookMain = new global::Gtk.Notebook();
			this.notebookMain.CanFocus = true;
			this.notebookMain.Name = "notebookMain";
			this.notebookMain.CurrentPage = 0;
			// Container child notebookMain.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w11 = new global::Gtk.Viewport();
			w11.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.datatableMain = new global::Gtk.Table(((uint)(8)), ((uint)(3)), false);
			this.datatableMain.Name = "datatableMain";
			this.datatableMain.RowSpacing = ((uint)(6));
			this.datatableMain.ColumnSpacing = ((uint)(6));
			this.datatableMain.BorderWidth = ((uint)(6));
			// Container child datatableMain.Gtk.Table+TableChild
			this.dataentryDrivingNumber = new global::Gamma.GtkWidgets.yEntry();
			this.dataentryDrivingNumber.TooltipMarkup = "Десять символов серии и номера без пробелов.";
			this.dataentryDrivingNumber.CanFocus = true;
			this.dataentryDrivingNumber.Name = "dataentryDrivingNumber";
			this.dataentryDrivingNumber.IsEditable = true;
			this.dataentryDrivingNumber.MaxLength = 45;
			this.dataentryDrivingNumber.InvisibleChar = '●';
			this.datatableMain.Add(this.dataentryDrivingNumber);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.dataentryDrivingNumber]));
			w12.TopAttach = ((uint)(7));
			w12.BottomAttach = ((uint)(8));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.dataentryLastName = new global::Gamma.GtkWidgets.yEntry();
			this.dataentryLastName.CanFocus = true;
			this.dataentryLastName.Name = "dataentryLastName";
			this.dataentryLastName.IsEditable = true;
			this.dataentryLastName.InvisibleChar = '●';
			this.datatableMain.Add(this.dataentryLastName);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.dataentryLastName]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.dataentryName = new global::Gamma.GtkWidgets.yEntry();
			this.dataentryName.CanFocus = true;
			this.dataentryName.Name = "dataentryName";
			this.dataentryName.IsEditable = true;
			this.dataentryName.MaxLength = 100;
			this.dataentryName.InvisibleChar = '●';
			this.datatableMain.Add(this.dataentryName);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.dataentryName]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.dataentryPatronymic = new global::Gamma.GtkWidgets.yEntry();
			this.dataentryPatronymic.CanFocus = true;
			this.dataentryPatronymic.Name = "dataentryPatronymic";
			this.dataentryPatronymic.IsEditable = true;
			this.dataentryPatronymic.InvisibleChar = '●';
			this.datatableMain.Add(this.dataentryPatronymic);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.dataentryPatronymic]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.entryAddressCurrent = new global::Gamma.GtkWidgets.yEntry();
			this.entryAddressCurrent.CanFocus = true;
			this.entryAddressCurrent.Name = "entryAddressCurrent";
			this.entryAddressCurrent.IsEditable = true;
			this.entryAddressCurrent.InvisibleChar = '●';
			this.datatableMain.Add(this.entryAddressCurrent);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.entryAddressCurrent]));
			w16.TopAttach = ((uint)(6));
			w16.BottomAttach = ((uint)(7));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.entryAddressRegistration = new global::Gamma.GtkWidgets.yEntry();
			this.entryAddressRegistration.CanFocus = true;
			this.entryAddressRegistration.Name = "entryAddressRegistration";
			this.entryAddressRegistration.IsEditable = true;
			this.entryAddressRegistration.InvisibleChar = '●';
			this.datatableMain.Add(this.entryAddressRegistration);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.entryAddressRegistration]));
			w17.TopAttach = ((uint)(5));
			w17.BottomAttach = ((uint)(6));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Телефон:");
			this.datatableMain.Add(this.label10);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.label10]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Водительское удостоверение:");
			this.datatableMain.Add(this.label11);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.label11]));
			w19.TopAttach = ((uint)(7));
			w19.BottomAttach = ((uint)(8));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.Xalign = 1F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("Адрес регистрации:");
			this.datatableMain.Add(this.label14);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.label14]));
			w20.TopAttach = ((uint)(5));
			w20.BottomAttach = ((uint)(6));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.Xalign = 1F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Фактический адрес:");
			this.datatableMain.Add(this.label15);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.label15]));
			w21.TopAttach = ((uint)(6));
			w21.BottomAttach = ((uint)(7));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Фамилия:");
			this.label2.UseMarkup = true;
			this.datatableMain.Add(this.label2);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.label2]));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Имя:");
			this.datatableMain.Add(this.label5);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.label5]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Отчество:");
			this.datatableMain.Add(this.label6);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.label6]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Национальность:");
			this.datatableMain.Add(this.label7);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.label7]));
			w25.TopAttach = ((uint)(3));
			w25.BottomAttach = ((uint)(4));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.phonesView = new global::QSContacts.PhonesView();
			this.phonesView.Events = ((global::Gdk.EventMask)(256));
			this.phonesView.Name = "phonesView";
			this.phonesView.IsReadOnly = false;
			this.datatableMain.Add(this.phonesView);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.phonesView]));
			w26.TopAttach = ((uint)(4));
			w26.BottomAttach = ((uint)(5));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(3));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.photoviewEmployee = new global::QS.Widgets.GtkUI.PhotoView();
			this.photoviewEmployee.Events = ((global::Gdk.EventMask)(256));
			this.photoviewEmployee.Name = "photoviewEmployee";
			this.photoviewEmployee.CanPrint = false;
			this.datatableMain.Add(this.photoviewEmployee);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.photoviewEmployee]));
			w27.BottomAttach = ((uint)(4));
			w27.LeftAttach = ((uint)(2));
			w27.RightAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.referenceNationality = new global::Gamma.Widgets.yEntryReference();
			this.referenceNationality.Events = ((global::Gdk.EventMask)(256));
			this.referenceNationality.Name = "referenceNationality";
			this.datatableMain.Add(this.referenceNationality);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.datatableMain[this.referenceNationality]));
			w28.TopAttach = ((uint)(3));
			w28.BottomAttach = ((uint)(4));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			w11.Add(this.datatableMain);
			this.GtkScrolledWindow.Add(w11);
			this.notebookMain.Add(this.GtkScrolledWindow);
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Информация");
			this.notebookMain.SetTabLabel(this.GtkScrolledWindow, this.label1);
			this.label1.ShowAll();
			// Container child notebookMain.Gtk.Notebook+NotebookChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			this.vbox5.BorderWidth = ((uint)(6));
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("ИНН:");
			this.hbox6.Add(this.label19);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label19]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.entryInn = new global::Gamma.GtkWidgets.yEntry();
			this.entryInn.CanFocus = true;
			this.entryInn.Name = "entryInn";
			this.entryInn.IsEditable = true;
			this.entryInn.InvisibleChar = '●';
			this.hbox6.Add(this.entryInn);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entryInn]));
			w33.Position = 1;
			this.vbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox6]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.accountsView = new global::QSBanks.AccountsView();
			this.accountsView.Events = ((global::Gdk.EventMask)(256));
			this.accountsView.Name = "accountsView";
			this.vbox5.Add(this.accountsView);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.accountsView]));
			w35.Position = 1;
			this.notebookMain.Add(this.vbox5);
			global::Gtk.Notebook.NotebookChild w36 = ((global::Gtk.Notebook.NotebookChild)(this.notebookMain[this.vbox5]));
			w36.Position = 1;
			// Notebook tab
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("Реквизиты");
			this.notebookMain.SetTabLabel(this.vbox5, this.label17);
			this.label17.ShowAll();
			// Container child notebookMain.Gtk.Notebook+NotebookChild
			this.attachmentFiles = new global::QSAttachment.Attachment();
			this.attachmentFiles.Events = ((global::Gdk.EventMask)(256));
			this.attachmentFiles.Name = "attachmentFiles";
			this.notebookMain.Add(this.attachmentFiles);
			global::Gtk.Notebook.NotebookChild w37 = ((global::Gtk.Notebook.NotebookChild)(this.notebookMain[this.attachmentFiles]));
			w37.Position = 2;
			// Notebook tab
			this.label24 = new global::Gtk.Label();
			this.label24.Name = "label24";
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString("Файлы");
			this.notebookMain.SetTabLabel(this.attachmentFiles, this.label24);
			this.label24.ShowAll();
			// Container child notebookMain.Gtk.Notebook+NotebookChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Добавить");
			global::Gtk.Image w38 = new global::Gtk.Image();
			w38.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.button1.Image = w38;
			this.hbox12.Add(this.button1);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.button1]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.buttonDocumentEdit = new global::Gtk.Button();
			this.buttonDocumentEdit.CanFocus = true;
			this.buttonDocumentEdit.Name = "buttonDocumentEdit";
			this.buttonDocumentEdit.UseUnderline = true;
			this.buttonDocumentEdit.Label = global::Mono.Unix.Catalog.GetString("Изменить");
			global::Gtk.Image w40 = new global::Gtk.Image();
			w40.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.buttonDocumentEdit.Image = w40;
			this.hbox12.Add(this.buttonDocumentEdit);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.buttonDocumentEdit]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			global::Gtk.Image w42 = new global::Gtk.Image();
			w42.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-remove", global::Gtk.IconSize.Menu);
			this.button3.Image = w42;
			this.hbox12.Add(this.button3);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.button3]));
			w43.Position = 2;
			w43.Expand = false;
			w43.Fill = false;
			this.vbox6.Add(this.hbox12);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox12]));
			w44.Position = 0;
			w44.Expand = false;
			w44.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			this.ytreeviewEmployeeDocument = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewEmployeeDocument.CanFocus = true;
			this.ytreeviewEmployeeDocument.Name = "ytreeviewEmployeeDocument";
			this.GtkScrolledWindow4.Add(this.ytreeviewEmployeeDocument);
			this.vbox6.Add(this.GtkScrolledWindow4);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.GtkScrolledWindow4]));
			w46.Position = 1;
			this.notebookMain.Add(this.vbox6);
			global::Gtk.Notebook.NotebookChild w47 = ((global::Gtk.Notebook.NotebookChild)(this.notebookMain[this.vbox6]));
			w47.Position = 3;
			// Notebook tab
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Документы");
			this.notebookMain.SetTabLabel(this.vbox6, this.label3);
			this.label3.ShowAll();
			this.vbox1.Add(this.notebookMain);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.notebookMain]));
			w48.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonChangeToEmployee = new global::Gtk.Button();
			this.buttonChangeToEmployee.CanFocus = true;
			this.buttonChangeToEmployee.Name = "buttonChangeToEmployee";
			this.buttonChangeToEmployee.UseUnderline = true;
			this.buttonChangeToEmployee.Label = global::Mono.Unix.Catalog.GetString("Перевести в сотрудники");
			this.hbox5.Add(this.buttonChangeToEmployee);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.buttonChangeToEmployee]));
			w49.PackType = ((global::Gtk.PackType)(1));
			w49.Position = 2;
			w49.Expand = false;
			w49.Fill = false;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w50.PackType = ((global::Gtk.PackType)(1));
			w50.Position = 2;
			w50.Expand = false;
			w50.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.radioTabInfo.Toggled += new global::System.EventHandler(this.OnRadioTabInfoToggled);
			this.radioTabAccounting.Toggled += new global::System.EventHandler(this.OnRadioTabAccountingToggled);
			this.radioTabFiles.Toggled += new global::System.EventHandler(this.OnRadioTabFilesToggled);
			this.radioTabDocuments.Toggled += new global::System.EventHandler(this.OnRadioTabDocumentsToggled);
			this.button1.Clicked += new global::System.EventHandler(this.OnButtonAddDocumentClicked);
			this.buttonDocumentEdit.Clicked += new global::System.EventHandler(this.OnButtonEditDocumentClicked);
			this.button3.Clicked += new global::System.EventHandler(this.OnButtonRemoveDocumentClicked);
			this.ytreeviewEmployeeDocument.RowActivated += new global::Gtk.RowActivatedHandler(this.OnEmployeeDocumentRowActivated);
			this.buttonChangeToEmployee.Clicked += new global::System.EventHandler(this.OnButtonChangeToEmployeeClicked);
		}
	}
}
