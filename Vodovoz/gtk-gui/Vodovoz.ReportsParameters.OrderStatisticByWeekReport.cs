
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ReportsParameters
{
	public partial class OrderStatisticByWeekReport
	{
		private global::Gtk.Table table1;

		private global::Gtk.Button buttonRun;

		private global::QS.Widgets.GtkUI.DateRangePicker dateperiodpicker;

		private global::Gtk.Label label1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReportsParameters.OrderStatisticByWeekReport
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReportsParameters.OrderStatisticByWeekReport";
			// Container child Vodovoz.ReportsParameters.OrderStatisticByWeekReport.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonRun = new global::Gtk.Button();
			this.buttonRun.CanFocus = true;
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.UseUnderline = true;
			this.buttonRun.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.table1.Add(this.buttonRun);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonRun]));
			w1.TopAttach = ((uint)(3));
			w1.BottomAttach = ((uint)(4));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(0));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.dateperiodpicker = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.dateperiodpicker.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpicker.Name = "dateperiodpicker";
			this.dateperiodpicker.StartDate = new global::System.DateTime(0);
			this.dateperiodpicker.EndDate = new global::System.DateTime(0);
			this.table1.Add(this.dateperiodpicker);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.dateperiodpicker]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Период:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonRun.Clicked += new global::System.EventHandler(this.OnButtonRunClicked);
		}
	}
}
