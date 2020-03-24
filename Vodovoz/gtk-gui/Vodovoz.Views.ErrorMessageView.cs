
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views
{
	public partial class ErrorMessageView
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Image image249;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label1;

		private global::Gtk.Label label3;

		private global::Gtk.Table table1;

		private global::Gamma.GtkWidgets.yEntry entryEmail;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTextView textviewDescription;

		private global::Gtk.Label label2;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Expander expander1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTextView textviewError;

		private global::Gtk.Label GtkLabel2;

		private global::Gtk.HBox hbox2;

		private global::Gamma.GtkWidgets.yLabel ylabel1;

		private global::Gamma.GtkWidgets.yButton ybuttonSendReport;

		private global::Gamma.GtkWidgets.yButton ybuttonCopy;

		private global::Gamma.GtkWidgets.yButton ybuttonOK;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.ErrorMessageView
			this.Name = "Vodovoz.Views.ErrorMessageView";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child Vodovoz.Views.ErrorMessageView.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.image249 = new global::Gtk.Image();
			this.image249.Name = "image249";
			this.image249.Xalign = 0F;
			this.image249.Yalign = 0F;
			this.image249.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-dialog-error", global::Gtk.IconSize.Dialog);
			this.hbox1.Add(this.image249);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.image249]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("К сожалению в программе произошла непредвиденная ошибка.");
			this.vbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Вы можете помочь нам улучшить программу и исправить данную проблему. \nДля этого в" +
					"оспользуйтесь формой отправки отчета об ошибке.\n");
			this.label3.Justify = ((global::Gtk.Justification)(3));
			this.vbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label3]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entryEmail = new global::Gamma.GtkWidgets.yEntry();
			this.entryEmail.CanFocus = true;
			this.entryEmail.Name = "entryEmail";
			this.entryEmail.IsEditable = true;
			this.entryEmail.InvisibleChar = '•';
			this.table1.Add(this.entryEmail);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.entryEmail]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textviewDescription = new global::Gamma.GtkWidgets.yTextView();
			this.textviewDescription.CanFocus = true;
			this.textviewDescription.Name = "textviewDescription";
			this.GtkScrolledWindow1.Add(this.textviewDescription);
			this.table1.Add(this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow1]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.TooltipMarkup = "В этом поле опишите последовательность действий, которая привела к возникновению " +
				"ошибки.";
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Описание:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.TooltipMarkup = "Для отправки отчета нам требуется ваш email. Мы будем использовать его, для уточн" +
				"ения информации об ошибке, а также для оперативного информирования об устранении" +
				" данной проблемы.";
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("E-mail для связи:");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Для отправки отчета, пожалуйста, заполните следующие поля:");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.expander1 = new global::Gtk.Expander(null);
			this.expander1.CanFocus = true;
			this.expander1.Name = "expander1";
			this.expander1.Expanded = true;
			// Container child expander1.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textviewError = new global::Gamma.GtkWidgets.yTextView();
			this.textviewError.CanFocus = true;
			this.textviewError.Name = "textviewError";
			this.textviewError.Editable = false;
			this.textviewError.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow.Add(this.textviewError);
			this.expander1.Add(this.GtkScrolledWindow);
			this.GtkLabel2 = new global::Gtk.Label();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("Техническая информация");
			this.GtkLabel2.UseUnderline = true;
			this.expander1.LabelWidget = this.GtkLabel2;
			this.vbox2.Add(this.expander1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.expander1]));
			w15.Position = 4;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w16.Position = 1;
			w1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(w1[this.hbox1]));
			w17.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ylabel1 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel1.Name = "ylabel1";
			this.hbox2.Add(this.ylabel1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ylabel1]));
			w18.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ybuttonSendReport = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonSendReport.WidthRequest = 140;
			this.ybuttonSendReport.CanFocus = true;
			this.ybuttonSendReport.Name = "ybuttonSendReport";
			this.ybuttonSendReport.UseUnderline = true;
			this.ybuttonSendReport.BorderWidth = ((uint)(2));
			this.ybuttonSendReport.Label = global::Mono.Unix.Catalog.GetString("Отправить отчет");
			global::Gtk.Image w19 = new global::Gtk.Image();
			w19.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-disconnect", global::Gtk.IconSize.Menu);
			this.ybuttonSendReport.Image = w19;
			this.hbox2.Add(this.ybuttonSendReport);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ybuttonSendReport]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ybuttonCopy = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonCopy.WidthRequest = 140;
			this.ybuttonCopy.CanFocus = true;
			this.ybuttonCopy.Name = "ybuttonCopy";
			this.ybuttonCopy.UseUnderline = true;
			this.ybuttonCopy.BorderWidth = ((uint)(2));
			this.ybuttonCopy.Label = global::Mono.Unix.Catalog.GetString("Скопировать");
			global::Gtk.Image w21 = new global::Gtk.Image();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-copy", global::Gtk.IconSize.Menu);
			this.ybuttonCopy.Image = w21;
			this.hbox2.Add(this.ybuttonCopy);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ybuttonCopy]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ybuttonOK = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonOK.WidthRequest = 140;
			this.ybuttonOK.CanFocus = true;
			this.ybuttonOK.Name = "ybuttonOK";
			this.ybuttonOK.UseUnderline = true;
			this.ybuttonOK.BorderWidth = ((uint)(2));
			this.ybuttonOK.Label = global::Mono.Unix.Catalog.GetString("Понятно");
			global::Gtk.Image w23 = new global::Gtk.Image();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-close", global::Gtk.IconSize.Menu);
			this.ybuttonOK.Image = w23;
			this.hbox2.Add(this.ybuttonOK);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ybuttonOK]));
			w24.Position = 3;
			w24.Expand = false;
			w24.Fill = false;
			w1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(w1[this.hbox2]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Internal child Vodovoz.Views.ErrorMessageView.ActionArea
			global::Gtk.HButtonBox w26 = this.ActionArea;
			w26.Sensitive = false;
			w26.Name = "dialog1_ActionArea";
			w26.Spacing = 10;
			w26.BorderWidth = ((uint)(5));
			w26.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26[this.buttonCancel]));
			w27.Expand = false;
			w27.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26[this.buttonOk]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1055;
			this.DefaultHeight = 786;
			w26.Hide();
			this.Show();
		}
	}
}
