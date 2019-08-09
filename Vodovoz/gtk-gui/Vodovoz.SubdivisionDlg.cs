
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class SubdivisionDlg
	{
		private global::Gtk.Table table1;

		private global::Gtk.Frame frmWarehoses;

		private global::Gtk.Alignment GtkAlignment4;

		private global::Gtk.Label lblWarehouses;

		private global::Gtk.Label GtkLabel8;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Notebook notebook1;

		private global::Vodovoz.Core.Permissions.SubdivisionEntityPermissionWidget subdivisionentitypermissionwidget;

		private global::Gtk.Label labelPermissions;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::QSOrmProject.RepresentationTreeView repTreeChildSubdivisions;

		private global::Gtk.Label labelChildSubdivizions;

		private global::Gtk.VBox vboxDocuments;

		private global::Gtk.ScrolledWindow GtkScrolledWindow4;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewDocuments;

		private global::Gtk.HBox hbox5;

		private global::Gamma.GtkWidgets.yButton buttonAddDocument;

		private global::Gamma.GtkWidgets.yButton buttonDeleteDocument;

		private global::Gtk.Label label3;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label labelShortName;

		private global::Gtk.Label lblGeographicGroup;

		private global::Gtk.Label lblParent;

		private global::Gamma.GtkWidgets.yEntry yentryName;

		private global::QS.Widgets.GtkUI.RepresentationEntry yentryreferenceChief;

		private global::Gamma.Widgets.yEntryReference yentryrefParentSubdivision;

		private global::Gamma.GtkWidgets.yEntry yentryShortName;

		private global::Gamma.Widgets.ySpecComboBox ySpecCmbGeographicGroup;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.SubdivisionDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.SubdivisionDlg";
			// Container child Vodovoz.SubdivisionDlg.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(7)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.frmWarehoses = new global::Gtk.Frame();
			this.frmWarehoses.Name = "frmWarehoses";
			this.frmWarehoses.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frmWarehoses.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			this.GtkAlignment4.LeftPadding = ((uint)(12));
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.lblWarehouses = new global::Gtk.Label();
			this.lblWarehouses.Name = "lblWarehouses";
			this.lblWarehouses.Xalign = 0F;
			this.lblWarehouses.LabelProp = global::Mono.Unix.Catalog.GetString("<b>?</b>");
			this.lblWarehouses.UseMarkup = true;
			this.lblWarehouses.Selectable = true;
			this.GtkAlignment4.Add(this.lblWarehouses);
			this.frmWarehoses.Add(this.GtkAlignment4);
			this.GtkLabel8 = new global::Gtk.Label();
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Склады отдела:</b>");
			this.GtkLabel8.UseMarkup = true;
			this.frmWarehoses.LabelWidget = this.GtkLabel8;
			this.table1.Add(this.frmWarehoses);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.frmWarehoses]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(6));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w4;
			this.hbox2.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonSave]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w6 = new global::Gtk.Image();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w6;
			this.hbox2.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonCancel]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.table1.Add(this.hbox2);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox2]));
			w8.RightAttach = ((uint)(3));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.subdivisionentitypermissionwidget = new global::Vodovoz.Core.Permissions.SubdivisionEntityPermissionWidget();
			this.subdivisionentitypermissionwidget.Events = ((global::Gdk.EventMask)(256));
			this.subdivisionentitypermissionwidget.Name = "subdivisionentitypermissionwidget";
			this.notebook1.Add(this.subdivisionentitypermissionwidget);
			// Notebook tab
			this.labelPermissions = new global::Gtk.Label();
			this.labelPermissions.Name = "labelPermissions";
			this.labelPermissions.LabelProp = global::Mono.Unix.Catalog.GetString("Права доступа");
			this.notebook1.SetTabLabel(this.subdivisionentitypermissionwidget, this.labelPermissions);
			this.labelPermissions.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.repTreeChildSubdivisions = new global::QSOrmProject.RepresentationTreeView();
			this.repTreeChildSubdivisions.CanFocus = true;
			this.repTreeChildSubdivisions.Name = "repTreeChildSubdivisions";
			this.GtkScrolledWindow2.Add(this.repTreeChildSubdivisions);
			this.notebook1.Add(this.GtkScrolledWindow2);
			global::Gtk.Notebook.NotebookChild w11 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.GtkScrolledWindow2]));
			w11.Position = 1;
			// Notebook tab
			this.labelChildSubdivizions = new global::Gtk.Label();
			this.labelChildSubdivizions.Name = "labelChildSubdivizions";
			this.labelChildSubdivizions.LabelProp = global::Mono.Unix.Catalog.GetString("Дочерние подразделения");
			this.notebook1.SetTabLabel(this.GtkScrolledWindow2, this.labelChildSubdivizions);
			this.labelChildSubdivizions.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vboxDocuments = new global::Gtk.VBox();
			this.vboxDocuments.Name = "vboxDocuments";
			this.vboxDocuments.Spacing = 6;
			// Container child vboxDocuments.Gtk.Box+BoxChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			this.ytreeviewDocuments = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewDocuments.CanFocus = true;
			this.ytreeviewDocuments.Name = "ytreeviewDocuments";
			this.GtkScrolledWindow4.Add(this.ytreeviewDocuments);
			this.vboxDocuments.Add(this.GtkScrolledWindow4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxDocuments[this.GtkScrolledWindow4]));
			w13.Position = 0;
			// Container child vboxDocuments.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonAddDocument = new global::Gamma.GtkWidgets.yButton();
			this.buttonAddDocument.CanFocus = true;
			this.buttonAddDocument.Name = "buttonAddDocument";
			this.buttonAddDocument.UseUnderline = true;
			this.buttonAddDocument.Label = global::Mono.Unix.Catalog.GetString("Добавить");
			this.hbox5.Add(this.buttonAddDocument);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.buttonAddDocument]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonDeleteDocument = new global::Gamma.GtkWidgets.yButton();
			this.buttonDeleteDocument.CanFocus = true;
			this.buttonDeleteDocument.Name = "buttonDeleteDocument";
			this.buttonDeleteDocument.UseUnderline = true;
			this.buttonDeleteDocument.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			this.hbox5.Add(this.buttonDeleteDocument);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.buttonDeleteDocument]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.vboxDocuments.Add(this.hbox5);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vboxDocuments[this.hbox5]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.notebook1.Add(this.vboxDocuments);
			global::Gtk.Notebook.NotebookChild w17 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vboxDocuments]));
			w17.Position = 2;
			// Notebook tab
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Документы");
			this.notebook1.SetTabLabel(this.vboxDocuments, this.label3);
			this.label3.ShowAll();
			this.hbox3.Add(this.notebook1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.notebook1]));
			w18.Position = 0;
			this.table1.Add(this.hbox3);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox3]));
			w19.TopAttach = ((uint)(6));
			w19.BottomAttach = ((uint)(7));
			w19.RightAttach = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Название подразделения:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Начальник подразделения:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelShortName = new global::Gtk.Label();
			this.labelShortName.Name = "labelShortName";
			this.labelShortName.Xalign = 1F;
			this.labelShortName.LabelProp = global::Mono.Unix.Catalog.GetString("Сокращенное наименование:");
			this.table1.Add(this.labelShortName);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.labelShortName]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblGeographicGroup = new global::Gtk.Label();
			this.lblGeographicGroup.Name = "lblGeographicGroup";
			this.lblGeographicGroup.Xalign = 1F;
			this.lblGeographicGroup.LabelProp = global::Mono.Unix.Catalog.GetString("Местоположение подразделения:");
			this.table1.Add(this.lblGeographicGroup);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.lblGeographicGroup]));
			w23.TopAttach = ((uint)(5));
			w23.BottomAttach = ((uint)(6));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblParent = new global::Gtk.Label();
			this.lblParent.Name = "lblParent";
			this.lblParent.Xalign = 1F;
			this.lblParent.LabelProp = global::Mono.Unix.Catalog.GetString("Вышестоящее подразделение:");
			this.table1.Add(this.lblParent);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.lblParent]));
			w24.TopAttach = ((uint)(4));
			w24.BottomAttach = ((uint)(5));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryName = new global::Gamma.GtkWidgets.yEntry();
			this.yentryName.CanFocus = true;
			this.yentryName.Name = "yentryName";
			this.yentryName.IsEditable = true;
			this.yentryName.InvisibleChar = '●';
			this.table1.Add(this.yentryName);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryName]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryreferenceChief = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.yentryreferenceChief.Events = ((global::Gdk.EventMask)(256));
			this.yentryreferenceChief.Name = "yentryreferenceChief";
			this.table1.Add(this.yentryreferenceChief);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryreferenceChief]));
			w26.TopAttach = ((uint)(3));
			w26.BottomAttach = ((uint)(4));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryrefParentSubdivision = new global::Gamma.Widgets.yEntryReference();
			this.yentryrefParentSubdivision.Events = ((global::Gdk.EventMask)(256));
			this.yentryrefParentSubdivision.Name = "yentryrefParentSubdivision";
			this.table1.Add(this.yentryrefParentSubdivision);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryrefParentSubdivision]));
			w27.TopAttach = ((uint)(4));
			w27.BottomAttach = ((uint)(5));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryShortName = new global::Gamma.GtkWidgets.yEntry();
			this.yentryShortName.CanFocus = true;
			this.yentryShortName.Name = "yentryShortName";
			this.yentryShortName.IsEditable = true;
			this.yentryShortName.MaxLength = 20;
			this.yentryShortName.InvisibleChar = '●';
			this.table1.Add(this.yentryShortName);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryShortName]));
			w28.TopAttach = ((uint)(2));
			w28.BottomAttach = ((uint)(3));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ySpecCmbGeographicGroup = new global::Gamma.Widgets.ySpecComboBox();
			this.ySpecCmbGeographicGroup.Name = "ySpecCmbGeographicGroup";
			this.ySpecCmbGeographicGroup.AddIfNotExist = false;
			this.ySpecCmbGeographicGroup.DefaultFirst = false;
			this.ySpecCmbGeographicGroup.ShowSpecialStateAll = false;
			this.ySpecCmbGeographicGroup.ShowSpecialStateNot = true;
			this.table1.Add(this.ySpecCmbGeographicGroup);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1[this.ySpecCmbGeographicGroup]));
			w29.TopAttach = ((uint)(5));
			w29.BottomAttach = ((uint)(6));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonAddDocument.Clicked += new global::System.EventHandler(this.OnButtonAddDocumentClicked);
			this.buttonDeleteDocument.Clicked += new global::System.EventHandler(this.OnButtonDeleteDocumentClicked);
		}
	}
}
