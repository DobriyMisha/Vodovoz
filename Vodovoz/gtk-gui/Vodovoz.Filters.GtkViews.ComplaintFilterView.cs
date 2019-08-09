
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Filters.GtkViews
{
	public partial class ComplaintFilterView
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox1;

		private global::Gtk.VBox vboxSubdivisions;

		private global::Gamma.GtkWidgets.yButton ybuttonAddSubdivision;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.Table table1;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboboxStatus;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboboxType;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Table table2;

		private global::Gtk.Label label3;

		private global::Gamma.Widgets.yEntryReferenceVM yentryreferencevmEmployee;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Filters.GtkViews.ComplaintFilterView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Filters.GtkViews.ComplaintFilterView";
			// Container child Vodovoz.Filters.GtkViews.ComplaintFilterView.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vboxSubdivisions = new global::Gtk.VBox();
			this.vboxSubdivisions.Name = "vboxSubdivisions";
			this.vboxSubdivisions.Spacing = 6;
			this.vbox1.Add(this.vboxSubdivisions);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vboxSubdivisions]));
			w1.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.ybuttonAddSubdivision = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonAddSubdivision.CanFocus = true;
			this.ybuttonAddSubdivision.Name = "ybuttonAddSubdivision";
			this.ybuttonAddSubdivision.UseUnderline = true;
			this.ybuttonAddSubdivision.Label = global::Mono.Unix.Catalog.GetString("Добавить подразделение");
			global::Gtk.Image w2 = new global::Gtk.Image();
			w2.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.ybuttonAddSubdivision.Image = w2;
			this.vbox1.Add(this.ybuttonAddSubdivision);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.ybuttonAddSubdivision]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.Name = "vseparator2";
			this.hbox1.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator2]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Тип");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Статус жалобы");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yenumcomboboxStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboboxStatus.Name = "yenumcomboboxStatus";
			this.yenumcomboboxStatus.ShowSpecialStateAll = false;
			this.yenumcomboboxStatus.ShowSpecialStateNot = true;
			this.yenumcomboboxStatus.UseShortTitle = false;
			this.yenumcomboboxStatus.DefaultFirst = false;
			this.table1.Add(this.yenumcomboboxStatus);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.yenumcomboboxStatus]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yenumcomboboxType = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboboxType.Name = "yenumcomboboxType";
			this.yenumcomboboxType.ShowSpecialStateAll = false;
			this.yenumcomboboxType.ShowSpecialStateNot = true;
			this.yenumcomboboxType.UseShortTitle = false;
			this.yenumcomboboxType.DefaultFirst = false;
			this.table1.Add(this.yenumcomboboxType);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.yenumcomboboxType]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox1.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator1]));
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Автор жалобы");
			this.table2.Add(this.label3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.yentryreferencevmEmployee = new global::Gamma.Widgets.yEntryReferenceVM();
			this.yentryreferencevmEmployee.Events = ((global::Gdk.EventMask)(256));
			this.yentryreferencevmEmployee.Name = "yentryreferencevmEmployee";
			this.table2.Add(this.yentryreferencevmEmployee);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2[this.yentryreferencevmEmployee]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table2]));
			w14.Position = 4;
			w14.Expand = false;
			w14.Fill = false;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
