
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class AccountingView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonDelete;

		private global::Gtk.CheckButton checkFilter;

		private global::Vodovoz.AccountingFilter accountingFilter;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::QSOrmProject.RepresentationTreeView tableAccountingOperations;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.AccountingView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.AccountingView";
			// Container child Vodovoz.AccountingView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonDelete = new global::Gtk.Button();
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			this.buttonDelete.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.buttonDelete.Image = w1;
			this.hbox3.Add(this.buttonDelete);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonDelete]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.checkFilter = new global::Gtk.CheckButton();
			this.checkFilter.CanFocus = true;
			this.checkFilter.Name = "checkFilter";
			this.checkFilter.Label = global::Mono.Unix.Catalog.GetString("Фильтр");
			this.checkFilter.DrawIndicator = false;
			this.checkFilter.UseUnderline = true;
			this.hbox3.Add(this.checkFilter);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.checkFilter]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 1;
			w3.Expand = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.accountingFilter = new global::Vodovoz.AccountingFilter();
			this.accountingFilter.Events = ((global::Gdk.EventMask)(256));
			this.accountingFilter.Name = "accountingFilter";
			this.vbox1.Add(this.accountingFilter);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.accountingFilter]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tableAccountingOperations = new global::QSOrmProject.RepresentationTreeView();
			this.tableAccountingOperations.CanFocus = true;
			this.tableAccountingOperations.Name = "tableAccountingOperations";
			this.GtkScrolledWindow.Add(this.tableAccountingOperations);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w7.Position = 2;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonDelete.Clicked += new global::System.EventHandler(this.OnButtonDeleteClicked);
			this.checkFilter.Toggled += new global::System.EventHandler(this.OnCheckFilterToggled);
		}
	}
}
