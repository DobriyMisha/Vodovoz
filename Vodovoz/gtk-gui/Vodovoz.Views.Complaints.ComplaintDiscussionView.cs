
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Complaints
{
	public partial class ComplaintDiscussionView
	{
		private global::Gtk.VBox vboxWidget;

		private global::Gtk.HBox hboxInfo;

		private global::Gamma.GtkWidgets.yLabel ylabelSubdivision;

		private global::Gtk.HBox hboxFields;

		private global::Gtk.Label labelPlannedCompletionDate;

		private global::QS.Widgets.GtkUI.DatePicker ydatepickerPlannedCompletionDate;

		private global::Gtk.Label labelStatus;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboStatus;

		private global::Gtk.Label labelComments;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewComments;

		private global::Gtk.Table tableNewComment;

		private global::Vodovoz.Views.FilesView filesview;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTextView ytextviewComment;

		private global::Gamma.GtkWidgets.yButton ybuttonAddComment;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Complaints.ComplaintDiscussionView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Complaints.ComplaintDiscussionView";
			// Container child Vodovoz.Views.Complaints.ComplaintDiscussionView.Gtk.Container+ContainerChild
			this.vboxWidget = new global::Gtk.VBox();
			this.vboxWidget.Name = "vboxWidget";
			this.vboxWidget.Spacing = 6;
			// Container child vboxWidget.Gtk.Box+BoxChild
			this.hboxInfo = new global::Gtk.HBox();
			this.hboxInfo.Name = "hboxInfo";
			this.hboxInfo.Spacing = 6;
			// Container child hboxInfo.Gtk.Box+BoxChild
			this.ylabelSubdivision = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelSubdivision.Name = "ylabelSubdivision";
			this.ylabelSubdivision.LabelProp = global::Mono.Unix.Catalog.GetString("###");
			this.ylabelSubdivision.UseMarkup = true;
			this.hboxInfo.Add(this.ylabelSubdivision);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hboxInfo[this.ylabelSubdivision]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.vboxWidget.Add(this.hboxInfo);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxWidget[this.hboxInfo]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vboxWidget.Gtk.Box+BoxChild
			this.hboxFields = new global::Gtk.HBox();
			this.hboxFields.Name = "hboxFields";
			this.hboxFields.Spacing = 6;
			// Container child hboxFields.Gtk.Box+BoxChild
			this.labelPlannedCompletionDate = new global::Gtk.Label();
			this.labelPlannedCompletionDate.Name = "labelPlannedCompletionDate";
			this.labelPlannedCompletionDate.LabelProp = global::Mono.Unix.Catalog.GetString("Дата план. завер.:");
			this.hboxFields.Add(this.labelPlannedCompletionDate);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxFields[this.labelPlannedCompletionDate]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hboxFields.Gtk.Box+BoxChild
			this.ydatepickerPlannedCompletionDate = new global::QS.Widgets.GtkUI.DatePicker();
			this.ydatepickerPlannedCompletionDate.Events = ((global::Gdk.EventMask)(256));
			this.ydatepickerPlannedCompletionDate.Name = "ydatepickerPlannedCompletionDate";
			this.ydatepickerPlannedCompletionDate.WithTime = false;
			this.ydatepickerPlannedCompletionDate.HideCalendarButton = false;
			this.ydatepickerPlannedCompletionDate.Date = new global::System.DateTime(0);
			this.ydatepickerPlannedCompletionDate.IsEditable = true;
			this.ydatepickerPlannedCompletionDate.AutoSeparation = false;
			this.hboxFields.Add(this.ydatepickerPlannedCompletionDate);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxFields[this.ydatepickerPlannedCompletionDate]));
			w4.Position = 1;
			// Container child hboxFields.Gtk.Box+BoxChild
			this.labelStatus = new global::Gtk.Label();
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Статус:");
			this.hboxFields.Add(this.labelStatus);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxFields[this.labelStatus]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hboxFields.Gtk.Box+BoxChild
			this.yenumcomboStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboStatus.Name = "yenumcomboStatus";
			this.yenumcomboStatus.ShowSpecialStateAll = false;
			this.yenumcomboStatus.ShowSpecialStateNot = false;
			this.yenumcomboStatus.UseShortTitle = false;
			this.yenumcomboStatus.DefaultFirst = false;
			this.hboxFields.Add(this.yenumcomboStatus);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxFields[this.yenumcomboStatus]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			this.vboxWidget.Add(this.hboxFields);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxWidget[this.hboxFields]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vboxWidget.Gtk.Box+BoxChild
			this.labelComments = new global::Gtk.Label();
			this.labelComments.Name = "labelComments";
			this.labelComments.Xalign = 0F;
			this.labelComments.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарии:");
			this.vboxWidget.Add(this.labelComments);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vboxWidget[this.labelComments]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vboxWidget.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewComments = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewComments.CanFocus = true;
			this.ytreeviewComments.Name = "ytreeviewComments";
			this.GtkScrolledWindow.Add(this.ytreeviewComments);
			this.vboxWidget.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxWidget[this.GtkScrolledWindow]));
			w10.Position = 3;
			// Container child vboxWidget.Gtk.Box+BoxChild
			this.tableNewComment = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.tableNewComment.Name = "tableNewComment";
			this.tableNewComment.RowSpacing = ((uint)(6));
			this.tableNewComment.ColumnSpacing = ((uint)(6));
			// Container child tableNewComment.Gtk.Table+TableChild
			this.filesview = new global::Vodovoz.Views.FilesView();
			this.filesview.WidthRequest = 250;
			this.filesview.Events = ((global::Gdk.EventMask)(256));
			this.filesview.Name = "filesview";
			this.tableNewComment.Add(this.filesview);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableNewComment[this.filesview]));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableNewComment.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.HeightRequest = 70;
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytextviewComment = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewComment.CanFocus = true;
			this.ytextviewComment.Name = "ytextviewComment";
			this.GtkScrolledWindow1.Add(this.ytextviewComment);
			this.tableNewComment.Add(this.GtkScrolledWindow1);
			// Container child tableNewComment.Gtk.Table+TableChild
			this.ybuttonAddComment = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonAddComment.CanFocus = true;
			this.ybuttonAddComment.Name = "ybuttonAddComment";
			this.ybuttonAddComment.UseUnderline = true;
			this.ybuttonAddComment.Label = global::Mono.Unix.Catalog.GetString("Добавить комментарий");
			this.tableNewComment.Add(this.ybuttonAddComment);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tableNewComment[this.ybuttonAddComment]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vboxWidget.Add(this.tableNewComment);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxWidget[this.tableNewComment]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			this.Add(this.vboxWidget);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
