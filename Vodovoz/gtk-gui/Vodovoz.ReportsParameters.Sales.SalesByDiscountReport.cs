
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ReportsParameters.Sales
{
	public partial class SalesByDiscountReport
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::QS.Widgets.GtkUI.DateRangePicker dateperiodpicker;

		private global::Gtk.HBox hboxDateType;

		private global::Gamma.GtkWidgets.yLabel ylabelDateType;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboboxDateType;

		private global::Gtk.HBox hboxDiscountReason;

		private global::Gamma.GtkWidgets.yLabel ylabel7;

		private global::Gamma.GtkWidgets.yLabel ylabelDiscountReason;

		private global::Gtk.Button buttonDiscountReasonSelect;

		private global::Gtk.Button buttonDiscountReasonUnselect;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Label labelTableTitle;

		private global::QSWidgetLib.SearchEntity searchEntityInSelectedList;

		private global::Gtk.Table table1;

		private global::Gtk.Button buttonSelectAll;

		private global::Gtk.Button buttonUnselectAll;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewSelectedList;

		private global::Gtk.Button buttonCreateReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReportsParameters.Sales.SalesByDiscountReport
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReportsParameters.Sales.SalesByDiscountReport";
			// Container child Vodovoz.ReportsParameters.Sales.SalesByDiscountReport.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Период:");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.dateperiodpicker = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.dateperiodpicker.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpicker.Name = "dateperiodpicker";
			this.dateperiodpicker.StartDate = new global::System.DateTime(0);
			this.dateperiodpicker.EndDate = new global::System.DateTime(0);
			this.hbox1.Add(this.dateperiodpicker);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.dateperiodpicker]));
			w2.Position = 1;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxDateType = new global::Gtk.HBox();
			this.hboxDateType.Name = "hboxDateType";
			this.hboxDateType.Spacing = 6;
			// Container child hboxDateType.Gtk.Box+BoxChild
			this.ylabelDateType = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelDateType.Name = "ylabelDateType";
			this.ylabelDateType.LabelProp = global::Mono.Unix.Catalog.GetString("Тип даты:");
			this.hboxDateType.Add(this.ylabelDateType);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxDateType[this.ylabelDateType]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hboxDateType.Gtk.Box+BoxChild
			this.yenumcomboboxDateType = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboboxDateType.Name = "yenumcomboboxDateType";
			this.yenumcomboboxDateType.ShowSpecialStateAll = false;
			this.yenumcomboboxDateType.ShowSpecialStateNot = false;
			this.yenumcomboboxDateType.UseShortTitle = false;
			this.yenumcomboboxDateType.DefaultFirst = false;
			this.hboxDateType.Add(this.yenumcomboboxDateType);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxDateType[this.yenumcomboboxDateType]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add(this.hboxDateType);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxDateType]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxDiscountReason = new global::Gtk.HBox();
			this.hboxDiscountReason.Name = "hboxDiscountReason";
			this.hboxDiscountReason.Spacing = 6;
			// Container child hboxDiscountReason.Gtk.Box+BoxChild
			this.ylabel7 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel7.Name = "ylabel7";
			this.ylabel7.Xalign = 0F;
			this.ylabel7.LabelProp = global::Mono.Unix.Catalog.GetString("Основания скидок: ");
			this.hboxDiscountReason.Add(this.ylabel7);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxDiscountReason[this.ylabel7]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hboxDiscountReason.Gtk.Box+BoxChild
			this.ylabelDiscountReason = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelDiscountReason.Name = "ylabelDiscountReason";
			this.ylabelDiscountReason.Xalign = 1F;
			this.hboxDiscountReason.Add(this.ylabelDiscountReason);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxDiscountReason[this.ylabelDiscountReason]));
			w8.Position = 1;
			// Container child hboxDiscountReason.Gtk.Box+BoxChild
			this.buttonDiscountReasonSelect = new global::Gtk.Button();
			this.buttonDiscountReasonSelect.CanFocus = true;
			this.buttonDiscountReasonSelect.Name = "buttonDiscountReasonSelect";
			this.buttonDiscountReasonSelect.UseUnderline = true;
			this.buttonDiscountReasonSelect.Label = global::Mono.Unix.Catalog.GetString("Вкл.");
			this.hboxDiscountReason.Add(this.buttonDiscountReasonSelect);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxDiscountReason[this.buttonDiscountReasonSelect]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hboxDiscountReason.Gtk.Box+BoxChild
			this.buttonDiscountReasonUnselect = new global::Gtk.Button();
			this.buttonDiscountReasonUnselect.CanFocus = true;
			this.buttonDiscountReasonUnselect.Name = "buttonDiscountReasonUnselect";
			this.buttonDiscountReasonUnselect.UseUnderline = true;
			this.buttonDiscountReasonUnselect.Label = global::Mono.Unix.Catalog.GetString("Искл.");
			this.hboxDiscountReason.Add(this.buttonDiscountReasonUnselect);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxDiscountReason[this.buttonDiscountReasonUnselect]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox1.Add(this.hboxDiscountReason);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxDiscountReason]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelTableTitle = new global::Gtk.Label();
			this.labelTableTitle.Name = "labelTableTitle";
			this.labelTableTitle.Xalign = 0F;
			this.vbox1.Add(this.labelTableTitle);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelTableTitle]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.searchEntityInSelectedList = new global::QSWidgetLib.SearchEntity();
			this.searchEntityInSelectedList.Events = ((global::Gdk.EventMask)(256));
			this.searchEntityInSelectedList.Name = "searchEntityInSelectedList";
			this.vbox1.Add(this.searchEntityInSelectedList);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.searchEntityInSelectedList]));
			w14.Position = 5;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonSelectAll = new global::Gtk.Button();
			this.buttonSelectAll.CanFocus = true;
			this.buttonSelectAll.Name = "buttonSelectAll";
			this.buttonSelectAll.UseUnderline = true;
			this.buttonSelectAll.Label = global::Mono.Unix.Catalog.GetString("Выбрать всех");
			this.table1.Add(this.buttonSelectAll);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonSelectAll]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonUnselectAll = new global::Gtk.Button();
			this.buttonUnselectAll.CanFocus = true;
			this.buttonUnselectAll.Name = "buttonUnselectAll";
			this.buttonUnselectAll.UseUnderline = true;
			this.buttonUnselectAll.Label = global::Mono.Unix.Catalog.GetString("Снять выделение");
			this.table1.Add(this.buttonUnselectAll);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonUnselectAll]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewSelectedList = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewSelectedList.CanFocus = true;
			this.ytreeviewSelectedList.Name = "ytreeviewSelectedList";
			this.GtkScrolledWindow.Add(this.ytreeviewSelectedList);
			this.table1.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow]));
			w18.RightAttach = ((uint)(2));
			this.vbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
			w19.Position = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonCreateReport = new global::Gtk.Button();
			this.buttonCreateReport.CanFocus = true;
			this.buttonCreateReport.Name = "buttonCreateReport";
			this.buttonCreateReport.UseUnderline = true;
			this.buttonCreateReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox1.Add(this.buttonCreateReport);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.buttonCreateReport]));
			w20.PackType = ((global::Gtk.PackType)(1));
			w20.Position = 7;
			w20.Expand = false;
			w20.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonDiscountReasonSelect.Clicked += new global::System.EventHandler(this.OnButtonDiscountReasonSelectClicked);
			this.buttonDiscountReasonUnselect.Clicked += new global::System.EventHandler(this.OnButtonDiscountReasonUnselectClicked);
			this.searchEntityInSelectedList.TextChanged += new global::System.EventHandler(this.OnSearchEntityInSelectedListTextChanged);
			this.buttonUnselectAll.Clicked += new global::System.EventHandler(this.OnButtonUnselectAllClicked);
			this.buttonSelectAll.Clicked += new global::System.EventHandler(this.OnButtonSelectAllClicked);
			this.buttonCreateReport.Clicked += new global::System.EventHandler(this.OnButtonCreateReportClicked);
		}
	}
}
