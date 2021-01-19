
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Accounting
{
	public partial class WayBillGeneratorView
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Label label28;

		private global::QS.Widgets.GtkUI.DateRangePicker dateRangeFilter;

		private global::Gamma.GtkWidgets.yButton yGenerateBtn;

		private global::Gamma.GtkWidgets.yButton yPrintBtn;

		private global::Gamma.GtkWidgets.yButton yUnloadBtn;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView yTreeWayBills;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Accounting.WayBillGeneratorView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Accounting.WayBillGeneratorView";
			// Container child Vodovoz.Views.Accounting.WayBillGeneratorView.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.label28 = new global::Gtk.Label();
			this.label28.Name = "label28";
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString("Дата:");
			this.hbox10.Add(this.label28);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.label28]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.dateRangeFilter = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.dateRangeFilter.Events = ((global::Gdk.EventMask)(256));
			this.dateRangeFilter.Name = "dateRangeFilter";
			this.dateRangeFilter.StartDate = new global::System.DateTime(0);
			this.dateRangeFilter.EndDate = new global::System.DateTime(0);
			this.hbox10.Add(this.dateRangeFilter);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.dateRangeFilter]));
			w2.Position = 1;
			w2.Expand = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.yGenerateBtn = new global::Gamma.GtkWidgets.yButton();
			this.yGenerateBtn.CanFocus = true;
			this.yGenerateBtn.Name = "yGenerateBtn";
			this.yGenerateBtn.UseUnderline = true;
			this.yGenerateBtn.Label = global::Mono.Unix.Catalog.GetString("Сформировать");
			this.hbox10.Add(this.yGenerateBtn);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.yGenerateBtn]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.yPrintBtn = new global::Gamma.GtkWidgets.yButton();
			this.yPrintBtn.CanFocus = true;
			this.yPrintBtn.Name = "yPrintBtn";
			this.yPrintBtn.UseUnderline = true;
			this.yPrintBtn.Label = global::Mono.Unix.Catalog.GetString("Печать");
			this.hbox10.Add(this.yPrintBtn);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.yPrintBtn]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.yUnloadBtn = new global::Gamma.GtkWidgets.yButton();
			this.yUnloadBtn.CanFocus = true;
			this.yUnloadBtn.Name = "yUnloadBtn";
			this.yUnloadBtn.UseUnderline = true;
			this.yUnloadBtn.Label = global::Mono.Unix.Catalog.GetString("Выгрузить");
			this.hbox10.Add(this.yUnloadBtn);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.yUnloadBtn]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox3.Add(this.hbox10);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox10]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.yTreeWayBills = new global::Gamma.GtkWidgets.yTreeView();
			this.yTreeWayBills.CanFocus = true;
			this.yTreeWayBills.Name = "yTreeWayBills";
			this.GtkScrolledWindow.Add(this.yTreeWayBills);
			this.vbox3.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.GtkScrolledWindow]));
			w8.Position = 1;
			this.vbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
			w9.Position = 0;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
