
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class ReturnsReceptionView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Frame frameReturns;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow3;

		private global::Gamma.GtkWidgets.yTreeView ytreeReturns;

		private global::Gtk.Label GtkLabel2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonAddNomenclature;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReturnsReceptionView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReturnsReceptionView";
			// Container child Vodovoz.ReturnsReceptionView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frameReturns = new global::Gtk.Frame();
			this.frameReturns.Name = "frameReturns";
			this.frameReturns.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameReturns.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.ytreeReturns = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeReturns.CanFocus = true;
			this.ytreeReturns.Name = "ytreeReturns";
			this.GtkScrolledWindow3.Add(this.ytreeReturns);
			this.GtkAlignment1.Add(this.GtkScrolledWindow3);
			this.frameReturns.Add(this.GtkAlignment1);
			this.GtkLabel2 = new global::Gtk.Label();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Возврат недовоза</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frameReturns.LabelWidget = this.GtkLabel2;
			this.vbox1.Add(this.frameReturns);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frameReturns]));
			w4.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonAddNomenclature = new global::Gtk.Button();
			this.buttonAddNomenclature.CanFocus = true;
			this.buttonAddNomenclature.Name = "buttonAddNomenclature";
			this.buttonAddNomenclature.UseUnderline = true;
			this.buttonAddNomenclature.Label = global::Mono.Unix.Catalog.GetString("Добавить отсутствующие");
			global::Gtk.Image w5 = new global::Gtk.Image();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddNomenclature.Image = w5;
			this.hbox2.Add(this.buttonAddNomenclature);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonAddNomenclature]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonAddNomenclature.Clicked += new global::System.EventHandler(this.OnButtonAddNomenclatureClicked);
		}
	}
}
