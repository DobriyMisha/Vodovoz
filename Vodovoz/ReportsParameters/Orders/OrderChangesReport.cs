using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QS.Report;
using QSReport;
using Vodovoz.Domain.Organizations;
using Gamma.ColumnConfig;
using Gamma.Utilities;
using QS.DomainModel.Entity;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using Vodovoz.Parameters;
using Vodovoz.Services;

namespace Vodovoz.ReportsParameters.Orders
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class OrderChangesReport : SingleUoWWidgetBase, IParametersWidget
    {
        private List<SelectedChangeTypeNode> changeTypes = new List<SelectedChangeTypeNode>();
        private readonly IReportDefaultsProvider reportDefaultsProvider;
        private readonly IOrderParametersProvider orderParametersProvider;

        public OrderChangesReport(IReportDefaultsProvider reportDefaultsProvider, IOrderParametersProvider orderParametersProvider)
        {
            this.reportDefaultsProvider = reportDefaultsProvider ?? throw new ArgumentNullException(nameof(reportDefaultsProvider));
            this.orderParametersProvider = orderParametersProvider ?? throw new ArgumentNullException(nameof(orderParametersProvider));
            this.Build();
            Configure();
        }

        private void Configure()
        {
            UoW = UnitOfWorkFactory.CreateWithoutRoot();
            buttonCreateReport.Clicked += OnButtonCreateReportClicked;
            dateperiodpicker.StartDate = DateTime.Today.AddDays(-1);
            dateperiodpicker.EndDate = DateTime.Today.AddDays(-1);
            dateperiodpicker.PeriodChangedByUser += OnDateChanged;
            var organizations = UoW.GetAll<Organization>();
            comboOrganization.ItemsList = organizations;
            comboOrganization.SetRenderTextFunc<Organization>(x => x.FullName);
            comboOrganization.Changed += (sender, e) => UpdateSensitivity();
            comboOrganization.SelectedItem = organizations.FirstOrDefault(x => x.Id == reportDefaultsProvider.GetDefaultOrderChangesOrganizationId);
            ytreeviewChangeTypes.ColumnsConfig = FluentColumnsConfig<SelectedChangeTypeNode>.Create()
                .AddColumn("✓").AddToggleRenderer(x => x.Selected)
                .AddColumn("Тип").AddTextRenderer(x => x.Title)
                .Finish();

            AddChangeType("Фактическое кол-во товара", "ActualCount");
            AddChangeType("Цена товара", "Price");
            AddChangeType("Добавление/Удаление товаров", "OrderItemsCount");
            AddChangeType("Тип оплаты заказа", "PaymentType");

            ytreeviewChangeTypes.ItemsDataSource = changeTypes;

            comboIssueType.ItemsEnum = typeof(IssueType);
        }

        private void AddChangeType(string title, string value)
        {
            var changeType = new SelectedChangeTypeNode();
            changeType.Title = title;
            changeType.Value = value;
            changeType.PropertyChanged += (sender, e) => UpdateSensitivity();
            changeType.Selected = true;
            changeTypes.Add(changeType);
        }

        #region IParametersWidget implementation

        public string Title => "Отчет по изменениям заказа при доставке";

        public event EventHandler<LoadReportEventArgs> LoadReport;

        #endregion IParametersWidget implementation

        private ReportInfo GetReportInfo()
        {
            var ordganizationId = ((Organization)comboOrganization.SelectedItem).Id;
            var selectedChangeTypes = string.Join(",", changeTypes.Where(x => x.Selected).Select(x => x.Value));
            var selectedChangeTypesTitles = string.Join(", ", changeTypes.Where(x => x.Selected).Select(x => x.Title));

            var parameters = new Dictionary<string, object>
                {
                    { "start_date", dateperiodpicker.StartDate },
                    { "end_date", dateperiodpicker.EndDate },
                    { "organization_id", ordganizationId },
                    { "change_types", selectedChangeTypes },
                    { "change_types_rus", selectedChangeTypesTitles },
                    { "issue_type", comboIssueType.SelectedItem },
                    { "sms_payment_from_id", orderParametersProvider.PaymentByCardFromSmsId },
                    { "issue_type_rus", ((IssueType)comboIssueType.SelectedItem).GetEnumTitle() }
                };

            return new ReportInfo
            {
                Identifier = "Orders.OrderChangesReport",
                UseUserVariables = true,
                Parameters = parameters
            };
        }

        private void OnButtonCreateReportClicked(object sender, EventArgs e)
        {
            if (dateperiodpicker.StartDateOrNull == null
                || (dateperiodpicker.StartDateOrNull != null && dateperiodpicker.StartDate >= DateTime.Now)
                || comboOrganization.SelectedItem == null
                || !changeTypes.Any(x => x.Selected)
                ) {
                return;
            }

            var reportInfo = GetReportInfo();
            LoadReport?.Invoke(this, new LoadReportEventArgs(reportInfo));
        }
        
        private void UpdateSensitivity()
        {
            bool hasValidDate = dateperiodpicker.StartDateOrNull != null && dateperiodpicker.StartDate < DateTime.Now;
            bool hasOrganization = comboOrganization.SelectedItem != null;
            bool hasChangeTypes = changeTypes.Any(x => x.Selected);
            bool issueTypeSelected = comboIssueType.SelectedItem is IssueType;
            buttonCreateReport.Sensitive = hasValidDate && hasOrganization && hasChangeTypes && issueTypeSelected;
        }

        private void UpdatePeriodMessage()
        {
            if(dateperiodpicker.StartDateOrNull == null) {
                ylabelDateWarning.Visible = false;
                return;
            }

            var period = DateTime.Now - dateperiodpicker.StartDate;
            ylabelDateWarning.Visible = period.Days > 14;
        }

        private void OnDateChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
            UpdatePeriodMessage();
        }

        public enum IssueType
        {
            [Display(Name = "Проблемы с нал. и безнал. оплатой")]
            CashAndCashlessIssues,
            [Display(Name = "Проблемы менеджеров")]
            IssueManagers,
            [Display(Name = "Проблемы с SMS")]
            SmsIssues,
            [Display(Name = "Проблемы с терминалами")]
            TerminalIssues
        }
    }

    public class SelectedChangeTypeNode : PropertyChangedBase
    {
        private bool selected;
        public virtual bool Selected
        {
            get => selected;
            set => SetField(ref selected, value);
        }

        public string Title { get; set; }

        public string Value { get; set; }
    }
}
