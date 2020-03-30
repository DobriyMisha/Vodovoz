
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class DailyRentAgreementDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Table datatable1;

		private global::Vodovoz.DailyRentPackagesView dailyrentpackagesview1;

		private global::QS.Widgets.GtkUI.DatePicker dateEnd;

		private global::QS.Widgets.GtkUI.DatePicker dateStart;

		private global::Gtk.HBox hbox7;

		private global::QS.Widgets.GtkUI.DatePicker dateIssue;

		private global::Gtk.Label label7;

		private global::Gamma.GtkWidgets.ySpinButton spinRentDays;

		private global::Gtk.Label label8;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label6;

		private global::Gtk.Label label9;

		private global::QS.Widgets.GtkUI.RepresentationEntry referenceDeliveryPoint;

		private global::QSDocTemplates.TemplateWidget templatewidget3;

		private global::Gamma.GtkWidgets.yLabel ylabelNumber;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.DailyRentAgreementDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.DailyRentAgreementDlg";
			// Container child Vodovoz.DailyRentAgreementDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отмена");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox1.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.datatable1 = new global::Gtk.Table(((uint)(5)), ((uint)(5)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.BorderWidth = ((uint)(6));
			// Container child datatable1.Gtk.Table+TableChild
			this.dailyrentpackagesview1 = new global::Vodovoz.DailyRentPackagesView();
			this.dailyrentpackagesview1.Events = ((global::Gdk.EventMask)(256));
			this.dailyrentpackagesview1.Name = "dailyrentpackagesview1";
			this.dailyrentpackagesview1.IsEditable = true;
			this.datatable1.Add(this.dailyrentpackagesview1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable1[this.dailyrentpackagesview1]));
			w6.TopAttach = ((uint)(4));
			w6.BottomAttach = ((uint)(5));
			w6.RightAttach = ((uint)(5));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.dateEnd = new global::QS.Widgets.GtkUI.DatePicker();
			this.dateEnd.Events = ((global::Gdk.EventMask)(256));
			this.dateEnd.Name = "dateEnd";
			this.dateEnd.WithTime = false;
			this.dateEnd.HideCalendarButton = false;
			this.dateEnd.Date = new global::System.DateTime(0);
			this.dateEnd.IsEditable = true;
			this.dateEnd.AutoSeparation = false;
			this.datatable1.Add(this.dateEnd);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.datatable1[this.dateEnd]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(3));
			w7.RightAttach = ((uint)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.dateStart = new global::QS.Widgets.GtkUI.DatePicker();
			this.dateStart.Events = ((global::Gdk.EventMask)(256));
			this.dateStart.Name = "dateStart";
			this.dateStart.WithTime = false;
			this.dateStart.HideCalendarButton = false;
			this.dateStart.Date = new global::System.DateTime(0);
			this.dateStart.IsEditable = true;
			this.dateStart.AutoSeparation = false;
			this.datatable1.Add(this.dateStart);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.datatable1[this.dateStart]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.dateIssue = new global::QS.Widgets.GtkUI.DatePicker();
			this.dateIssue.Events = ((global::Gdk.EventMask)(256));
			this.dateIssue.Name = "dateIssue";
			this.dateIssue.WithTime = false;
			this.dateIssue.HideCalendarButton = false;
			this.dateIssue.Date = new global::System.DateTime(0);
			this.dateIssue.IsEditable = true;
			this.dateIssue.AutoSeparation = false;
			this.hbox7.Add(this.dateIssue);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.dateIssue]));
			w9.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Срок аренды:");
			this.hbox7.Add(this.label7);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label7]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.spinRentDays = new global::Gamma.GtkWidgets.ySpinButton(0D, 100D, 1D);
			this.spinRentDays.CanFocus = true;
			this.spinRentDays.Name = "spinRentDays";
			this.spinRentDays.Adjustment.PageIncrement = 10D;
			this.spinRentDays.ClimbRate = 1D;
			this.spinRentDays.Numeric = true;
			this.spinRentDays.ValueAsDecimal = 0m;
			this.spinRentDays.ValueAsInt = 0;
			this.hbox7.Add(this.spinRentDays);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.spinRentDays]));
			w11.Position = 2;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("дней");
			this.hbox7.Add(this.label8);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label8]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			this.datatable1.Add(this.hbox7);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatable1[this.hbox7]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Точка доставки:");
			this.datatable1.Add(this.label2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label2]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Дата создания:");
			this.datatable1.Add(this.label3);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label3]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Дата начала действия:");
			this.datatable1.Add(this.label4);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label4]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Номер доп. соглашения:");
			this.datatable1.Add(this.label6);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label6]));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Дата окончания действия:");
			this.datatable1.Add(this.label9);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label9]));
			w18.TopAttach = ((uint)(2));
			w18.BottomAttach = ((uint)(3));
			w18.LeftAttach = ((uint)(2));
			w18.RightAttach = ((uint)(3));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceDeliveryPoint = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.referenceDeliveryPoint.Events = ((global::Gdk.EventMask)(256));
			this.referenceDeliveryPoint.Name = "referenceDeliveryPoint";
			this.datatable1.Add(this.referenceDeliveryPoint);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.datatable1[this.referenceDeliveryPoint]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.templatewidget3 = new global::QSDocTemplates.TemplateWidget();
			this.templatewidget3.Events = ((global::Gdk.EventMask)(256));
			this.templatewidget3.Name = "templatewidget3";
			this.templatewidget3.CanRevertCommon = false;
			this.datatable1.Add(this.templatewidget3);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.datatable1[this.templatewidget3]));
			w20.BottomAttach = ((uint)(4));
			w20.LeftAttach = ((uint)(4));
			w20.RightAttach = ((uint)(5));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.ylabelNumber = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelNumber.Name = "ylabelNumber";
			this.ylabelNumber.Xalign = 0F;
			this.ylabelNumber.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel1");
			this.datatable1.Add(this.ylabelNumber);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.datatable1[this.ylabelNumber]));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(4));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.datatable1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.datatable1]));
			w22.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.dateStart.DateChanged += new global::System.EventHandler(this.OnDateStartDateChanged);
			this.dateEnd.DateChanged += new global::System.EventHandler(this.OnDateEndDateChanged);
		}
	}
}
