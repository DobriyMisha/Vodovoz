﻿using System;
using System.Collections.Generic;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QS.Project.Journal.EntitySelector;
using QS.Report;
using QSReport;
using Vodovoz.Domain.Client;

namespace Vodovoz.ReportsParameters.Payments
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class PaymentsFromBankClientReport : SingleUoWWidgetBase, IParametersWidget
	{
		public PaymentsFromBankClientReport(IEntityAutocompleteSelectorFactory counterpartySelectorFactory)
		{
			this.Build();
			UoW = UnitOfWorkFactory.CreateWithoutRoot();
			btnCreateReport.Clicked += (sender, e) => Validate();
			yentryRefSubdivision.SubjectType = typeof(Subdivision);
            entryCounterparty.SetEntityAutocompleteSelectorFactory(counterpartySelectorFactory);
		}

		#region IParametersWidget implementation

		public string Title => "Отчет по оплатам";

		public event EventHandler<LoadReportEventArgs> LoadReport;

		#endregion

		private ReportInfo GetReportInfo()
		{
			string reportName;
			var parameters = new Dictionary<string, object>();

			if(checkAllSubdivisions.Active) {
				reportName = "Payments.PaymentsFromBankClientAllSubdivisionsReport";
			} else {
				reportName = "Payments.PaymentsFromBankClientBySubdivisionReport";
				parameters.Add("subdivision_id", ((Subdivision)yentryRefSubdivision.Subject).Id);
                parameters.Add("counterparty_id", ((Counterparty)entryCounterparty.Subject)?.Id ?? 0);
                parameters.Add("sort_date", checkSortDate.Active);
			}

			parameters.Add("date", DateTime.Today);

			return new ReportInfo {
				Identifier = reportName,
				Parameters = parameters
			};
		}

		void Validate()
		{
			string errorString = string.Empty;
			if(yentryRefSubdivision.Subject == null && !checkAllSubdivisions.Active)
				errorString += "Не заполнено подразделение!\n";
			if(yentryRefSubdivision.Subject != null && checkAllSubdivisions.Active)
				errorString += "Данные установки протеворечат логике работы!\n";
			if(!string.IsNullOrWhiteSpace(errorString)) {
				MessageDialogHelper.RunErrorDialog(errorString);
				return;
			}
			OnUpdate(true);
		}

		void OnUpdate(bool hide = false) => LoadReport?.Invoke(this, new LoadReportEventArgs(GetReportInfo(), hide));
	}
}
