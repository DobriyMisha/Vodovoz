
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Core.Journal
{
	public partial class MultipleEntityJournal
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hboxButtons;

		private global::Gtk.HBox hboxButtonActions;

		private global::Gtk.CheckButton checkShowFilter;

		private global::Gtk.Button buttonRefresh;

		private global::Gtk.HBox hboxFilter;

		private global::Gtk.HBox hboxSearch;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entrySearch;

		private global::Gamma.GtkWidgets.yLabel ylabelSearchAnd;

		private global::Gtk.Entry entrySearch2;

		private global::Gamma.GtkWidgets.yLabel ylabelSearchAnd2;

		private global::Gtk.Entry entrySearch3;

		private global::Gamma.GtkWidgets.yLabel ylabelSearchAnd3;

		private global::Gtk.Entry entrySearch4;

		private global::Gtk.Button buttonAddAnd;

		private global::Gtk.Button buttonSearchClear;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::QS.Widgets.GtkUI.RepresentationTreeView tableview;

		private global::Gtk.Label labelSum;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Core.Journal.MultipleEntityJournal
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Core.Journal.MultipleEntityJournal";
			// Container child Vodovoz.Core.Journal.MultipleEntityJournal.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxButtons = new global::Gtk.HBox();
			this.hboxButtons.Name = "hboxButtons";
			this.hboxButtons.Spacing = 6;
			// Container child hboxButtons.Gtk.Box+BoxChild
			this.hboxButtonActions = new global::Gtk.HBox();
			this.hboxButtonActions.Name = "hboxButtonActions";
			this.hboxButtonActions.Spacing = 6;
			this.hboxButtons.Add(this.hboxButtonActions);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hboxButtons[this.hboxButtonActions]));
			w1.Position = 0;
			// Container child hboxButtons.Gtk.Box+BoxChild
			this.checkShowFilter = new global::Gtk.CheckButton();
			this.checkShowFilter.CanFocus = true;
			this.checkShowFilter.Name = "checkShowFilter";
			this.checkShowFilter.Label = global::Mono.Unix.Catalog.GetString("Фильтр");
			this.checkShowFilter.DrawIndicator = false;
			this.checkShowFilter.UseUnderline = true;
			this.hboxButtons.Add(this.checkShowFilter);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxButtons[this.checkShowFilter]));
			w2.PackType = ((global::Gtk.PackType)(1));
			w2.Position = 1;
			w2.Expand = false;
			// Container child hboxButtons.Gtk.Box+BoxChild
			this.buttonRefresh = new global::Gtk.Button();
			this.buttonRefresh.CanFocus = true;
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.UseUnderline = true;
			this.buttonRefresh.Label = global::Mono.Unix.Catalog.GetString("Обновить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-refresh", global::Gtk.IconSize.Menu);
			this.buttonRefresh.Image = w3;
			this.hboxButtons.Add(this.buttonRefresh);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxButtons[this.buttonRefresh]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hboxButtons);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxButtons]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxFilter = new global::Gtk.HBox();
			this.hboxFilter.Name = "hboxFilter";
			this.hboxFilter.Spacing = 6;
			this.vbox1.Add(this.hboxFilter);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxFilter]));
			w6.Position = 1;
			w6.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxSearch = new global::Gtk.HBox();
			this.hboxSearch.Name = "hboxSearch";
			this.hboxSearch.Spacing = 6;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Поиск:");
			this.hboxSearch.Add(this.label1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.label1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.entrySearch = new global::Gtk.Entry();
			this.entrySearch.WidthRequest = 50;
			this.entrySearch.CanFocus = true;
			this.entrySearch.Name = "entrySearch";
			this.entrySearch.IsEditable = true;
			this.entrySearch.InvisibleChar = '●';
			this.hboxSearch.Add(this.entrySearch);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.entrySearch]));
			w8.Position = 1;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.ylabelSearchAnd = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelSearchAnd.Name = "ylabelSearchAnd";
			this.ylabelSearchAnd.LabelProp = global::Mono.Unix.Catalog.GetString("и");
			this.hboxSearch.Add(this.ylabelSearchAnd);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.ylabelSearchAnd]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.entrySearch2 = new global::Gtk.Entry();
			this.entrySearch2.WidthRequest = 50;
			this.entrySearch2.CanFocus = true;
			this.entrySearch2.Name = "entrySearch2";
			this.entrySearch2.IsEditable = true;
			this.entrySearch2.InvisibleChar = '●';
			this.hboxSearch.Add(this.entrySearch2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.entrySearch2]));
			w10.Position = 3;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.ylabelSearchAnd2 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelSearchAnd2.Name = "ylabelSearchAnd2";
			this.ylabelSearchAnd2.LabelProp = global::Mono.Unix.Catalog.GetString("и");
			this.hboxSearch.Add(this.ylabelSearchAnd2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.ylabelSearchAnd2]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.entrySearch3 = new global::Gtk.Entry();
			this.entrySearch3.WidthRequest = 50;
			this.entrySearch3.CanFocus = true;
			this.entrySearch3.Name = "entrySearch3";
			this.entrySearch3.IsEditable = true;
			this.entrySearch3.InvisibleChar = '●';
			this.hboxSearch.Add(this.entrySearch3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.entrySearch3]));
			w12.Position = 5;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.ylabelSearchAnd3 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelSearchAnd3.Name = "ylabelSearchAnd3";
			this.ylabelSearchAnd3.LabelProp = global::Mono.Unix.Catalog.GetString("и");
			this.hboxSearch.Add(this.ylabelSearchAnd3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.ylabelSearchAnd3]));
			w13.Position = 6;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.entrySearch4 = new global::Gtk.Entry();
			this.entrySearch4.WidthRequest = 50;
			this.entrySearch4.CanFocus = true;
			this.entrySearch4.Name = "entrySearch4";
			this.entrySearch4.IsEditable = true;
			this.entrySearch4.InvisibleChar = '●';
			this.hboxSearch.Add(this.entrySearch4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.entrySearch4]));
			w14.Position = 7;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.buttonAddAnd = new global::Gtk.Button();
			this.buttonAddAnd.CanFocus = true;
			this.buttonAddAnd.Name = "buttonAddAnd";
			this.buttonAddAnd.UseUnderline = true;
			this.buttonAddAnd.Label = global::Mono.Unix.Catalog.GetString("И");
			global::Gtk.Image w15 = new global::Gtk.Image();
			w15.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddAnd.Image = w15;
			this.hboxSearch.Add(this.buttonAddAnd);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.buttonAddAnd]));
			w16.Position = 8;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hboxSearch.Gtk.Box+BoxChild
			this.buttonSearchClear = new global::Gtk.Button();
			this.buttonSearchClear.TooltipMarkup = "Очистить";
			this.buttonSearchClear.CanFocus = true;
			this.buttonSearchClear.Name = "buttonSearchClear";
			this.buttonSearchClear.UseUnderline = true;
			global::Gtk.Image w17 = new global::Gtk.Image();
			w17.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.buttonSearchClear.Image = w17;
			this.hboxSearch.Add(this.buttonSearchClear);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hboxSearch[this.buttonSearchClear]));
			w18.Position = 9;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox1.Add(this.hboxSearch);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxSearch]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tableview = new global::QS.Widgets.GtkUI.RepresentationTreeView();
			this.tableview.CanFocus = true;
			this.tableview.Name = "tableview";
			this.GtkScrolledWindow.Add(this.tableview);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w21.Position = 3;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelSum = new global::Gtk.Label();
			this.labelSum.Name = "labelSum";
			this.labelSum.Xpad = 6;
			this.labelSum.Xalign = 1F;
			this.labelSum.LabelProp = global::Mono.Unix.Catalog.GetString("label2");
			this.labelSum.SingleLineMode = true;
			this.vbox1.Add(this.labelSum);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelSum]));
			w22.Position = 4;
			w22.Expand = false;
			w22.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.checkShowFilter.Hide();
			this.hboxFilter.Hide();
			this.ylabelSearchAnd.Hide();
			this.entrySearch2.Hide();
			this.ylabelSearchAnd2.Hide();
			this.entrySearch3.Hide();
			this.ylabelSearchAnd3.Hide();
			this.entrySearch4.Hide();
			this.Hide();
			this.buttonRefresh.Clicked += new global::System.EventHandler(this.OnButtonRefreshClicked);
			this.checkShowFilter.Toggled += new global::System.EventHandler(this.OnCheckShowFilterToggled);
			this.entrySearch.Changed += new global::System.EventHandler(this.OnEntrySearchChanged);
			this.entrySearch2.Changed += new global::System.EventHandler(this.OnEntrySearchChanged);
			this.entrySearch3.Changed += new global::System.EventHandler(this.OnEntrySearchChanged);
			this.entrySearch4.Changed += new global::System.EventHandler(this.OnEntrySearchChanged);
			this.buttonAddAnd.Clicked += new global::System.EventHandler(this.OnButtonAddAndClicked);
			this.buttonSearchClear.Clicked += new global::System.EventHandler(this.OnButtonSearchClearClicked);
			this.tableview.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTableviewRowActivated);
		}
	}
}
