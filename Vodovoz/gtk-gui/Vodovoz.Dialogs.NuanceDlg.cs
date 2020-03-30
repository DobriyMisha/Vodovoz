
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Dialogs
{
	public partial class NuanceDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Table datatable5;

		private global::Gtk.Button buttonCreateTemplate;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::QSOrmProject.RepresentationTreeView representationtreeview1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTextView ytextCommentFinal;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSelectTemplate;

		private global::Gtk.Label label11;

		private global::Gamma.Widgets.yEntryReference referenceAuthor;

		private global::QSWidgetLib.SearchEntity searchentity2;

		private global::Gtk.Table table2;

		private global::Gamma.GtkWidgets.yCheckButton checkCommentFixed;

		private global::Gamma.Widgets.yEnumComboBox enumAncorPoint;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::QS.Widgets.GtkUI.RepresentationEntry referenceClient;

		private global::QS.Widgets.GtkUI.RepresentationEntry referenceDeliveryPoint;

		private global::Gamma.Widgets.yEntryReference referenceOrder;

		private global::Gtk.SpinButton spinbutton1;

		private global::QS.Widgets.GtkUI.RepresentationEntry yentryreferencevm1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Dialogs.NuanceDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Dialogs.NuanceDlg";
			// Container child Vodovoz.Dialogs.NuanceDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
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
			this.datatable5 = new global::Gtk.Table(((uint)(6)), ((uint)(4)), false);
			this.datatable5.Name = "datatable5";
			this.datatable5.RowSpacing = ((uint)(6));
			this.datatable5.ColumnSpacing = ((uint)(6));
			this.datatable5.BorderWidth = ((uint)(6));
			// Container child datatable5.Gtk.Table+TableChild
			this.buttonCreateTemplate = new global::Gtk.Button();
			this.buttonCreateTemplate.CanFocus = true;
			this.buttonCreateTemplate.Name = "buttonCreateTemplate";
			this.buttonCreateTemplate.UseUnderline = true;
			this.buttonCreateTemplate.Label = global::Mono.Unix.Catalog.GetString("Создать шаблон");
			this.datatable5.Add(this.buttonCreateTemplate);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable5[this.buttonCreateTemplate]));
			w6.TopAttach = ((uint)(5));
			w6.BottomAttach = ((uint)(6));
			w6.LeftAttach = ((uint)(3));
			w6.RightAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child datatable5.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.representationtreeview1 = new global::QSOrmProject.RepresentationTreeView();
			this.representationtreeview1.CanFocus = true;
			this.representationtreeview1.Name = "representationtreeview1";
			this.GtkScrolledWindow.Add(this.representationtreeview1);
			this.datatable5.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.datatable5[this.GtkScrolledWindow]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.RightAttach = ((uint)(3));
			// Container child datatable5.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytextCommentFinal = new global::Gamma.GtkWidgets.yTextView();
			this.ytextCommentFinal.CanFocus = true;
			this.ytextCommentFinal.Name = "ytextCommentFinal";
			this.GtkScrolledWindow1.Add(this.ytextCommentFinal);
			this.datatable5.Add(this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.datatable5[this.GtkScrolledWindow1]));
			w10.TopAttach = ((uint)(5));
			w10.BottomAttach = ((uint)(6));
			w10.RightAttach = ((uint)(3));
			w10.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child datatable5.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSelectTemplate = new global::Gtk.Button();
			this.buttonSelectTemplate.CanFocus = true;
			this.buttonSelectTemplate.Name = "buttonSelectTemplate";
			this.buttonSelectTemplate.UseUnderline = true;
			this.buttonSelectTemplate.Label = global::Mono.Unix.Catalog.GetString("Выбрать шаблон");
			this.hbox1.Add(this.buttonSelectTemplate);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSelectTemplate]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			this.datatable5.Add(this.hbox1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatable5[this.hbox1]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable5.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Автор:");
			this.datatable5.Add(this.label11);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatable5[this.label11]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(3));
			w13.RightAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable5.Gtk.Table+TableChild
			this.referenceAuthor = new global::Gamma.Widgets.yEntryReference();
			this.referenceAuthor.Sensitive = false;
			this.referenceAuthor.Events = ((global::Gdk.EventMask)(256));
			this.referenceAuthor.Name = "referenceAuthor";
			this.datatable5.Add(this.referenceAuthor);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.datatable5[this.referenceAuthor]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(3));
			w14.RightAttach = ((uint)(4));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable5.Gtk.Table+TableChild
			this.searchentity2 = new global::QSWidgetLib.SearchEntity();
			this.searchentity2.Events = ((global::Gdk.EventMask)(256));
			this.searchentity2.Name = "searchentity2";
			this.datatable5.Add(this.searchentity2);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.datatable5[this.searchentity2]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable5.Gtk.Table+TableChild
			this.table2 = new global::Gtk.Table(((uint)(13)), ((uint)(1)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.checkCommentFixed = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkCommentFixed.CanFocus = true;
			this.checkCommentFixed.Name = "checkCommentFixed";
			this.checkCommentFixed.Label = global::Mono.Unix.Catalog.GetString("Фиксированный");
			this.checkCommentFixed.Active = true;
			this.checkCommentFixed.DrawIndicator = true;
			this.checkCommentFixed.UseUnderline = true;
			this.checkCommentFixed.Xalign = 0F;
			this.table2.Add(this.checkCommentFixed);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2[this.checkCommentFixed]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.enumAncorPoint = new global::Gamma.Widgets.yEnumComboBox();
			this.enumAncorPoint.Name = "enumAncorPoint";
			this.enumAncorPoint.ShowSpecialStateAll = false;
			this.enumAncorPoint.ShowSpecialStateNot = false;
			this.enumAncorPoint.UseShortTitle = false;
			this.enumAncorPoint.DefaultFirst = false;
			this.table2.Add(this.enumAncorPoint);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2[this.enumAncorPoint]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Поля привязки:");
			this.table2.Add(this.label12);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2[this.label12]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Клиент:");
			this.table2.Add(this.label13);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2[this.label13]));
			w19.TopAttach = ((uint)(4));
			w19.BottomAttach = ((uint)(5));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Точка доставки:");
			this.table2.Add(this.label3);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
			w20.TopAttach = ((uint)(6));
			w20.BottomAttach = ((uint)(7));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Заказ:");
			this.table2.Add(this.label4);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
			w21.TopAttach = ((uint)(8));
			w21.BottomAttach = ((uint)(9));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.referenceClient = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.referenceClient.Events = ((global::Gdk.EventMask)(256));
			this.referenceClient.Name = "referenceClient";
			this.table2.Add(this.referenceClient);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2[this.referenceClient]));
			w22.TopAttach = ((uint)(5));
			w22.BottomAttach = ((uint)(6));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.referenceDeliveryPoint = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.referenceDeliveryPoint.Events = ((global::Gdk.EventMask)(256));
			this.referenceDeliveryPoint.Name = "referenceDeliveryPoint";
			this.table2.Add(this.referenceDeliveryPoint);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2[this.referenceDeliveryPoint]));
			w23.TopAttach = ((uint)(7));
			w23.BottomAttach = ((uint)(8));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.referenceOrder = new global::Gamma.Widgets.yEntryReference();
			this.referenceOrder.TooltipMarkup = "При проставлении логистического района у данной точки доставки он проставится у в" +
				"сех точек доставки с совпадающим до номера дома включительно адресом.";
			this.referenceOrder.Events = ((global::Gdk.EventMask)(256));
			this.referenceOrder.Name = "referenceOrder";
			this.table2.Add(this.referenceOrder);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2[this.referenceOrder]));
			w24.TopAttach = ((uint)(9));
			w24.BottomAttach = ((uint)(10));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.spinbutton1 = new global::Gtk.SpinButton(0D, 100D, 1D);
			this.spinbutton1.CanFocus = true;
			this.spinbutton1.Name = "spinbutton1";
			this.spinbutton1.Adjustment.PageIncrement = 10D;
			this.spinbutton1.ClimbRate = 1D;
			this.spinbutton1.Numeric = true;
			this.table2.Add(this.spinbutton1);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2[this.spinbutton1]));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.yentryreferencevm1 = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.yentryreferencevm1.Events = ((global::Gdk.EventMask)(256));
			this.yentryreferencevm1.Name = "yentryreferencevm1";
			this.table2.Add(this.yentryreferencevm1);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2[this.yentryreferencevm1]));
			w26.TopAttach = ((uint)(10));
			w26.BottomAttach = ((uint)(11));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			this.datatable5.Add(this.table2);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.datatable5[this.table2]));
			w27.TopAttach = ((uint)(3));
			w27.BottomAttach = ((uint)(4));
			w27.LeftAttach = ((uint)(3));
			w27.RightAttach = ((uint)(4));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.datatable5);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.datatable5]));
			w28.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.enumAncorPoint.ChangedByUser += new global::System.EventHandler(this.OnEnumAncorPointChangedByUser);
			this.searchentity2.TextChanged += new global::System.EventHandler(this.OnSearchentity2TextChanged);
			this.buttonSelectTemplate.Clicked += new global::System.EventHandler(this.OnButtonSelectTemplateClicked);
			this.buttonCreateTemplate.Clicked += new global::System.EventHandler(this.OnButtonCreateTemplateClicked);
		}
	}
}
