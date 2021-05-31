﻿using System;
using System.Linq;
using Gamma.GtkWidgets;
using Gtk;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QS.Report;
using Vodovoz.Additions.Printing;
using Vodovoz.Domain.Logistic;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.Orders.Documents;
using Vodovoz.Domain.Orders.Documents.DriverTicket;
using Vodovoz.Domain.Orders.Documents.Invoice;
using Vodovoz.PrintableDocuments;
using Vodovoz.ViewModels.Infrastructure.Print;

namespace Vodovoz.Dialogs
{
	public partial class DocumentsPrinterDlg : QS.Dialog.Gtk.TdiTabBase
	{
		Order currentOrder;
		RouteList currentRouteList;
		SelectablePrintDocument selectedDocument;
		EntityDocumentsPrinter entityDocumentsPrinter;
		
		public event EventHandler DocumentsPrinted;

		public DocumentsPrinterDlg(Order order)
		{
			this.Build();

			TabName = "Печать документов заказа";

			entityDocumentsPrinter = new EntityDocumentsPrinter(order);
			if(!string.IsNullOrEmpty(entityDocumentsPrinter.ODTTemplateNotFoundMessages))
				MessageDialogHelper.RunWarningDialog(entityDocumentsPrinter.ODTTemplateNotFoundMessages);
			currentOrder = order;

			Configure();
		}

		public DocumentsPrinterDlg(
			IUnitOfWork uow,
			RouteList routeList,
			IEntityDocumentsPrinterFactory entityDocumentsPrinterFactory,
			RouteListPrintableDocuments selectedType)
		{
			this.Build();
			TabName = "Печать документов МЛ";
			entityDocumentsPrinter = new EntityDocumentsPrinter(uow, routeList, entityDocumentsPrinterFactory, selectedType);
			currentRouteList = routeList;

			Configure();
		}

		void Configure()
		{
			ytreeviewDocuments.ColumnsConfig = ColumnsConfigFactory.Create<SelectablePrintDocument>()
				.AddColumn("✓").AddToggleRenderer(x => x.Selected)
				.AddColumn("Документ").AddTextRenderer(x => x.Document.Name)
				.AddColumn("Копий").AddNumericRenderer(x => x.Copies).Editing()
					   .Adjustment(new Adjustment(0, 0, 10000, 1, 100, 0))
				.RowCells()
				.Finish();

			ytreeviewDocuments.ItemsDataSource = entityDocumentsPrinter.MultiDocPrinter.PrintableDocuments;

			DefaultPreviewDocument();
			entityDocumentsPrinter.DocumentsPrinted += (o, args) => DocumentsPrinted?.Invoke(o, args);
		}

		protected void DefaultPreviewDocument()
		{
			var printDocuments = entityDocumentsPrinter.DocumentsToPrint;
			if(currentOrder != null) { //если этот диалог вызван из заказа
				var documents = printDocuments.Where(x => x.Document is OrderDocument)
											  .Where(x => (x.Document as OrderDocument).Order.Id == currentOrder.Id);

				var driverTicket = documents.FirstOrDefault(x => x.Document is DriverTicketDocument);
				var invoiceDocument = documents.FirstOrDefault(x => x.Document is InvoiceDocument);
				if(driverTicket != null && currentOrder.PaymentType == Domain.Client.PaymentType.cashless) {
					selectedDocument = driverTicket;
					PreviewDocument();
				} else if(invoiceDocument != null) {
					selectedDocument = invoiceDocument;
					PreviewDocument();
				}
			} else if(currentRouteList != null) { //если этот диалог вызван из МЛ
				selectedDocument = printDocuments.FirstOrDefault(x => x.Selected) ?? printDocuments.FirstOrDefault();
				PreviewDocument();
			}
		}

		void PreviewDocument()
		{
			if(selectedDocument.Document is IPrintableRDLDocument rdldoc) {
				reportviewer.ReportPrinted -= Reportviewer_ReportPrinted;
				reportviewer.ReportPrinted += Reportviewer_ReportPrinted;
				var reportInfo = rdldoc.GetReportInfo();

				if(reportInfo.Source != null)
					reportviewer.LoadReport(reportInfo.Source, reportInfo.GetParametersString(), reportInfo.ConnectionString, true, reportInfo.RestrictedOutputPresentationTypes);
				else
					reportviewer.LoadReport(reportInfo.GetReportUri(), reportInfo.GetParametersString(), reportInfo.ConnectionString, true, reportInfo.RestrictedOutputPresentationTypes);
			}
		}

		void Reportviewer_ReportPrinted(object sender, EventArgs e) => DocumentsPrinted?.Invoke(this, new EndPrintArgs { Args = new[] { selectedDocument.Document } });

		protected void OnButtonPrintAllClicked(object sender, EventArgs e) => entityDocumentsPrinter.Print();

		protected void OnButtonPrintClicked(object sender, EventArgs e)
		{
			if(selectedDocument != null)
				entityDocumentsPrinter.Print(selectedDocument);
		}

		protected void OnYtreeviewDocumentsRowActivated(object o, RowActivatedArgs args)
		{
			selectedDocument = ytreeviewDocuments.GetSelectedObject() as SelectablePrintDocument;
			PreviewDocument();
		}

		protected void OnButtonCancelClicked(object sender, EventArgs e) => OnCloseTab(false);
	}
}