
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class FuelTypeDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Table table2;

		private global::Gtk.HBox hbox1;

		private global::Gamma.GtkWidgets.ySpinButton yspinbuttonCost;

		private global::Gtk.Label label1;

		private global::Gtk.Label label3;

		private global::Gamma.GtkWidgets.yEntry yentryName;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.FuelTypeDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.FuelTypeDlg";
			// Container child Vodovoz.FuelTypeDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(3));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox4.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox4.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.yspinbuttonCost = new global::Gamma.GtkWidgets.ySpinButton(0D, 1000D, 1D);
			this.yspinbuttonCost.CanFocus = true;
			this.yspinbuttonCost.Name = "yspinbuttonCost";
			this.yspinbuttonCost.Adjustment.PageIncrement = 1D;
			this.yspinbuttonCost.ClimbRate = 1D;
			this.yspinbuttonCost.Digits = ((uint)(2));
			this.yspinbuttonCost.Numeric = true;
			this.yspinbuttonCost.ValueAsDecimal = 0m;
			this.yspinbuttonCost.ValueAsInt = 0;
			this.hbox1.Add(this.yspinbuttonCost);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.yspinbuttonCost]));
			w6.Position = 0;
			this.table2.Add(this.hbox1);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.hbox1]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Название:");
			this.table2.Add(this.label1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2[this.label1]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Стоимость литра:");
			this.table2.Add(this.label3);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.yentryName = new global::Gamma.GtkWidgets.yEntry();
			this.yentryName.CanFocus = true;
			this.yentryName.Name = "yentryName";
			this.yentryName.IsEditable = true;
			this.yentryName.InvisibleChar = '●';
			this.table2.Add(this.yentryName);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2[this.yentryName]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table2]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonSave.Clicked += new global::System.EventHandler(this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.OnButtonCancelClicked);
		}
	}
}
