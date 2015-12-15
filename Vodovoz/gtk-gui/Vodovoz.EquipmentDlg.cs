
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class EquipmentDlg
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.VSeparator vseparator1;
		
		private global::Gtk.RadioButton radiobuttonSticker;
		
		private global::Gtk.RadioButton radiobuttonInfo;
		
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.DataBindings.DataTable datatable1;
		
		private global::Gtk.DataBindings.DataCheckButton checkOnDuty;
		
		private global::QSOrmProject.DataDatePicker dataLastService;
		
		private global::Gtk.DataBindings.DataEntry entrySerialNumber;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment6;
		
		private global::Gtk.Label labelWhere;
		
		private global::Gtk.Label GtkLabel10;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.DataBindings.DataTextView textComment;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.DataBindings.DataEntryReference referenceNomenclature;
		
		private global::Gamma.Widgets.yDatePicker ydatepickerWarrantyEnd;
		
		private global::Gtk.Label label2;
		
		private global::fyiReporting.RdlGtkViewer.ReportViewer reportviewerSticker;
		
		private global::Gtk.Label label3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.EquipmentDlg
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "Vodovoz.EquipmentDlg";
			// Container child Vodovoz.EquipmentDlg.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w3;
			this.hbox4.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonSave]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отменить");
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w5;
			this.hbox4.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonCancel]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator ();
			this.vseparator1.Name = "vseparator1";
			this.hbox4.Add (this.vseparator1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vseparator1]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.radiobuttonSticker = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Наклейка"));
			this.radiobuttonSticker.CanFocus = true;
			this.radiobuttonSticker.Name = "radiobuttonSticker";
			this.radiobuttonSticker.DrawIndicator = false;
			this.radiobuttonSticker.UseUnderline = true;
			this.radiobuttonSticker.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hbox4.Add (this.radiobuttonSticker);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.radiobuttonSticker]));
			w8.PackType = ((global::Gtk.PackType)(1));
			w8.Position = 3;
			// Container child hbox4.Gtk.Box+BoxChild
			this.radiobuttonInfo = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Информация"));
			this.radiobuttonInfo.CanFocus = true;
			this.radiobuttonInfo.Name = "radiobuttonInfo";
			this.radiobuttonInfo.DrawIndicator = false;
			this.radiobuttonInfo.UseUnderline = true;
			this.radiobuttonInfo.Group = this.radiobuttonSticker.Group;
			this.hbox4.Add (this.radiobuttonInfo);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.radiobuttonInfo]));
			w9.PackType = ((global::Gtk.PackType)(1));
			w9.Position = 4;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.datatable1 = new global::Gtk.DataBindings.DataTable (((uint)(7)), ((uint)(2)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			// Container child datatable1.Gtk.Table+TableChild
			this.checkOnDuty = new global::Gtk.DataBindings.DataCheckButton ();
			this.checkOnDuty.CanFocus = true;
			this.checkOnDuty.Name = "checkOnDuty";
			this.checkOnDuty.Label = "";
			this.checkOnDuty.DrawIndicator = true;
			this.checkOnDuty.UseUnderline = true;
			this.checkOnDuty.InheritedDataSource = true;
			this.checkOnDuty.Mappings = "OnDuty";
			this.checkOnDuty.InheritedBoundaryDataSource = false;
			this.checkOnDuty.Editable = true;
			this.checkOnDuty.AutomaticTitle = false;
			this.checkOnDuty.InheritedBoundaryDataSource = false;
			this.checkOnDuty.InheritedDataSource = true;
			this.checkOnDuty.Mappings = "OnDuty";
			this.datatable1.Add (this.checkOnDuty);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.checkOnDuty]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.dataLastService = new global::QSOrmProject.DataDatePicker ();
			this.dataLastService.Events = ((global::Gdk.EventMask)(256));
			this.dataLastService.Name = "dataLastService";
			this.dataLastService.Date = new global::System.DateTime (0);
			this.dataLastService.IsEditable = true;
			this.dataLastService.AutoSeparation = false;
			this.dataLastService.InheritedDataSource = true;
			this.dataLastService.Mappings = "LastServiceDate";
			this.dataLastService.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.dataLastService);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.dataLastService]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.entrySerialNumber = new global::Gtk.DataBindings.DataEntry ();
			this.entrySerialNumber.CanFocus = true;
			this.entrySerialNumber.Name = "entrySerialNumber";
			this.entrySerialNumber.IsEditable = false;
			this.entrySerialNumber.InvisibleChar = '●';
			this.entrySerialNumber.InheritedDataSource = true;
			this.entrySerialNumber.Mappings = "Serial";
			this.entrySerialNumber.InheritedBoundaryDataSource = false;
			this.entrySerialNumber.InheritedDataSource = true;
			this.entrySerialNumber.Mappings = "Serial";
			this.entrySerialNumber.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.entrySerialNumber);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.entrySerialNumber]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment6 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment6.Name = "GtkAlignment6";
			this.GtkAlignment6.LeftPadding = ((uint)(12));
			// Container child GtkAlignment6.Gtk.Container+ContainerChild
			this.labelWhere = new global::Gtk.Label ();
			this.labelWhere.Name = "labelWhere";
			this.labelWhere.Xalign = 0F;
			this.labelWhere.Yalign = 0F;
			this.labelWhere.LabelProp = global::Mono.Unix.Catalog.GetString ("Не определено");
			this.labelWhere.Wrap = true;
			this.labelWhere.Selectable = true;
			this.GtkAlignment6.Add (this.labelWhere);
			this.frame1.Add (this.GtkAlignment6);
			this.GtkLabel10 = new global::Gtk.Label ();
			this.GtkLabel10.Name = "GtkLabel10";
			this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Текущее расположение:</b>");
			this.GtkLabel10.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel10;
			this.datatable1.Add (this.frame1);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.frame1]));
			w16.TopAttach = ((uint)(6));
			w16.BottomAttach = ((uint)(7));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textComment = new global::Gtk.DataBindings.DataTextView ();
			this.textComment.CanFocus = true;
			this.textComment.Name = "textComment";
			this.textComment.InheritedDataSource = true;
			this.textComment.Mappings = "Comment";
			this.textComment.InheritedBoundaryDataSource = false;
			this.textComment.InheritedDataSource = true;
			this.textComment.Mappings = "Comment";
			this.textComment.InheritedBoundaryDataSource = false;
			this.GtkScrolledWindow.Add (this.textComment);
			this.datatable1.Add (this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.GtkScrolledWindow]));
			w18.TopAttach = ((uint)(5));
			w18.BottomAttach = ((uint)(6));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Комментарий:");
			this.datatable1.Add (this.label1);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label1]));
			w19.TopAttach = ((uint)(5));
			w19.BottomAttach = ((uint)(6));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Номенклатура:");
			this.label10.Justify = ((global::Gtk.Justification)(1));
			this.datatable1.Add (this.label10);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label10]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Серийный номер:");
			this.datatable1.Add (this.label11);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label11]));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Дежурный:");
			this.datatable1.Add (this.label7);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label7]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата окончания\nгарантии:");
			this.label8.Justify = ((global::Gtk.Justification)(1));
			this.datatable1.Add (this.label8);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label8]));
			w23.TopAttach = ((uint)(3));
			w23.BottomAttach = ((uint)(4));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата последней\nсан. обработки:");
			this.datatable1.Add (this.label9);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label9]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceNomenclature = new global::Gtk.DataBindings.DataEntryReference ();
			this.referenceNomenclature.Events = ((global::Gdk.EventMask)(256));
			this.referenceNomenclature.Name = "referenceNomenclature";
			this.referenceNomenclature.DisplayFields = new string[] {
				"Name"
			};
			this.referenceNomenclature.DisplayFormatString = "{0}";
			this.referenceNomenclature.InheritedDataSource = true;
			this.referenceNomenclature.Mappings = "Nomenclature";
			this.referenceNomenclature.ColumnMappings = "";
			this.referenceNomenclature.InheritedBoundaryDataSource = false;
			this.referenceNomenclature.CursorPointsEveryType = false;
			this.datatable1.Add (this.referenceNomenclature);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.referenceNomenclature]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.ydatepickerWarrantyEnd = new global::Gamma.Widgets.yDatePicker ();
			this.ydatepickerWarrantyEnd.Events = ((global::Gdk.EventMask)(256));
			this.ydatepickerWarrantyEnd.Name = "ydatepickerWarrantyEnd";
			this.ydatepickerWarrantyEnd.Date = new global::System.DateTime (0);
			this.ydatepickerWarrantyEnd.IsEditable = true;
			this.ydatepickerWarrantyEnd.AutoSeparation = false;
			this.datatable1.Add (this.ydatepickerWarrantyEnd);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.ydatepickerWarrantyEnd]));
			w26.TopAttach = ((uint)(3));
			w26.BottomAttach = ((uint)(4));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.datatable1);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Информация");
			this.notebook1.SetTabLabel (this.datatable1, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.reportviewerSticker = new global::fyiReporting.RdlGtkViewer.ReportViewer ();
			this.reportviewerSticker.WidthRequest = 0;
			this.reportviewerSticker.HeightRequest = 0;
			this.reportviewerSticker.Events = ((global::Gdk.EventMask)(256));
			this.reportviewerSticker.Name = "reportviewerSticker";
			this.reportviewerSticker.ShowErrors = false;
			this.reportviewerSticker.ShowParameters = false;
			this.notebook1.Add (this.reportviewerSticker);
			global::Gtk.Notebook.NotebookChild w28 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.reportviewerSticker]));
			w28.Position = 1;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Наклейка");
			this.notebook1.SetTabLabel (this.reportviewerSticker, this.label3);
			this.label3.ShowAll ();
			this.vbox3.Add (this.notebook1);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.notebook1]));
			w29.Position = 1;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.radiobuttonInfo.Toggled += new global::System.EventHandler (this.OnRadiobuttonInfoToggled);
			this.radiobuttonSticker.Toggled += new global::System.EventHandler (this.OnRadiobuttonStickerToggled);
		}
	}
}
