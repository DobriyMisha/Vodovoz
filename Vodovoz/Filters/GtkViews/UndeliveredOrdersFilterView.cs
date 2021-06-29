using System;
using Gamma.Widgets;
using QS.Views.GtkUI;
using Vodovoz.Domain.Orders;
using Vodovoz.ViewModels.Journals.FilterViewModels.Enums;
using Vodovoz.ViewModels.Journals.FilterViewModels.Orders;

namespace Vodovoz.Filters.GtkViews
{
	public partial class UndeliveredOrdersFilterView : FilterViewBase<UndeliveredOrdersFilterViewModel>
	{
		public UndeliveredOrdersFilterView(UndeliveredOrdersFilterViewModel filterViewModel) : base(filterViewModel)
		{
			this.Build();
			Configure();
		}

		private void Configure()
		{
			/*chkProblematicCases.Toggled += (sender, e) => {
				if(chkProblematicCases.Active)
				{
					yEnumCMBGuilty.SelectedItemOrNull = null;
					ySpecCMBGuiltyDep.Visible = lblGuiltyDep.Visible = false;
				}
				yEnumCMBGuilty.Sensitive = !chkProblematicCases.Active;
				OnRefiltered();
			};*/

			/*yenumcomboDebtPaymentType.ItemsEnum = typeof(PaymentType);
			yenumcomboDebtPaymentType.Binding.AddBinding(ViewModel.Entity, e => e.DebtPaymentType, w => w.SelectedItem).InitializeFromSource();
			yenumcomboDebtPaymentType.Sensitive = disablespinMoneyDebt.Active;*/
			chkProblematicCases.Binding.AddBinding(ViewModel, vm => vm.RestrictIsProblematicCases, w => w.Active).InitializeFromSource();

			
			/*yEnumCMBGuilty.Binding.AddBinding(ViewModel, vm => vm.RestrictIsProblematicCases, w => w.SelectedItemOrNull);*/


			yEnumCMBUndeliveryStatus.ItemsEnum = typeof(UndeliveryStatus);
			yEnumCMBUndeliveryStatus.Binding.AddBinding(ViewModel, vm => vm.RestrictUndeliveryStatus, w => w.SelectedItemOrNull).InitializeFromSource();

			yEnumCMBActionWithInvoice.ItemsEnum = typeof(ActionsWithInvoice);
			yEnumCMBActionWithInvoice.Binding.AddBinding(ViewModel, vm => vm.RestrictActionsWithInvoice, w => w.SelectedItemOrNull).InitializeFromSource();
			


			/*comboWarehouseFrom.Binding.AddBinding(ViewModel, vm => vm.WarehousesFrom, w => w.ItemsList).InitializeFromSource();
			comboWarehouseFrom.Binding.AddBinding(ViewModel.Entity, e => e.FromWarehouse, w => w.SelectedItem).InitializeFromSource();*/

			ySpecCMBinProcessAt.Binding.AddBinding(ViewModel, vm => vm.Subdivisions, w => w.ItemsList).InitializeFromSource();
			ySpecCMBinProcessAt.Binding.AddBinding(ViewModel, vm => vm.RestrictInProcessAtDepartment, w => w.SelectedItem).InitializeFromSource();




			ySpecCMBGuiltyDep.Binding.AddBinding(ViewModel, vm => vm.Subdivisions, w => w.ItemsList).InitializeFromSource();
			ySpecCMBGuiltyDep.Binding.AddBinding(ViewModel, vm => vm.RestrictGuiltyDepartment, w => w.SelectedItem).InitializeFromSource();
			ySpecCMBGuiltyDep.Binding.AddBinding(ViewModel, vm => vm.RestrictGuiltyDepartmentVisible, w => w.Visible).InitializeFromSource();
			ylabelGuiltyDep.Binding.AddBinding(ViewModel, vm => vm.RestrictGuiltyDepartmentVisible, w => w.Visible).InitializeFromSource();

			yEnumCMBGuilty.ItemsEnum = typeof(GuiltyTypes);
			yEnumCMBGuilty.Binding.AddBinding(ViewModel, vm => vm.RestrictGuiltySide, w => w.SelectedItemOrNull).InitializeFromSource();
			yEnumCMBGuilty.Binding.AddBinding(ViewModel, vm => vm.RestrictNotIsProblematicCases, w => w.Sensitive).InitializeFromSource();







			entryOldOrder.SetEntityAutocompleteSelectorFactory(ViewModel.OrderSelectorFactory);
			entryOldOrder.Binding.AddBinding(ViewModel, vm => vm.RestrictOldOrder, w => w.Subject).InitializeFromSource();
			entryOldOrder.Binding.AddBinding(ViewModel, vm => vm.CanDelete, w => w.CanEditReference).InitializeFromSource();

			entryDriver.SetEntityAutocompleteSelectorFactory(ViewModel.DriverSelectorFactory);
			entryDriver.Binding.AddBinding(ViewModel, vm => vm.RestrictDriver, w => w.Subject).InitializeFromSource();

			entryCounterparty.SetEntityAutocompleteSelectorFactory(ViewModel.CounterpartySelectorFactory);
			entryCounterparty.Binding.AddBinding(ViewModel, vm => vm.RestrictClient, w => w.Subject).InitializeFromSource();

			entryDeliveryPoint.SetEntityAutocompleteSelectorFactory(ViewModel.DeliveryPointSelectorFactory);
			entryDeliveryPoint.Binding.AddBinding(ViewModel, vm => vm.RestrictAddress, w => w.Subject).InitializeFromSource();

			entryOldOrderAuthor.SetEntityAutocompleteSelectorFactory(ViewModel.AuthorSelectorFactory);
			entryOldOrderAuthor.Binding.AddBinding(ViewModel, vm => vm.RestrictOldOrderAuthor, w => w.Subject).InitializeFromSource();

			entryUndeliveryAuthor.SetEntityAutocompleteSelectorFactory(ViewModel.AuthorSelectorFactory);
			entryUndeliveryAuthor.Binding.AddBinding(ViewModel, vm => vm.RestrictUndeliveryAuthor, w => w.Subject).InitializeFromSource();

			dateperiodOldOrderDate.Binding.AddBinding(ViewModel, vm=>vm.RestrictOldOrderStartDate, w=>w.StartDateOrNull).InitializeFromSource();
			dateperiodOldOrderDate.Binding.AddBinding(ViewModel, vm => vm.RestrictOldOrderEndDate, w => w.EndDateOrNull).InitializeFromSource();

			dateperiodNewOrderDate.Binding.AddBinding(ViewModel, vm => vm.RestrictNewOrderStartDate, w => w.StartDateOrNull).InitializeFromSource();
			dateperiodNewOrderDate.Binding.AddBinding(ViewModel, vm => vm.RestrictNewOrderEndDate, w => w.EndDateOrNull).InitializeFromSource();


			/*

			dateperiodOldOrderDate.StartDateOrNull = DateTime.Today.AddMonths(-1);
			dateperiodOldOrderDate.EndDateOrNull = DateTime.Today.AddMonths(1);

			chkProblematicCases.Toggled += (sender, e) => {
				if(chkProblematicCases.Active)
				{
					yEnumCMBGuilty.SelectedItemOrNull = null;
					ySpecCMBGuiltyDep.Visible = lblGuiltyDep.Visible = false;
				}
				yEnumCMBGuilty.Sensitive = !chkProblematicCases.Active;
				//OnRefiltered();
			};
			*/

			entryAuthorSubdivision.SetEntityAutocompleteSelectorFactory(ViewModel.SubdivisionSelectorFactory);
			entryAuthorSubdivision.Binding.AddBinding(ViewModel, vm => vm.RestrictAuthorSubdivision, w => w.Subject).InitializeFromSource();

			//Подразделение
			/*var employeeSelectorFactory =
				new DefaultEntityAutocompleteSelectorFactory
					<Employee, EmployeesJournalViewModel, EmployeeFilterViewModel>(ServicesConfig.CommonServices);

			var filter = new SubdivisionFilterViewModel() { SubdivisionType = SubdivisionType.Default };


			AuthorSubdivisionEntityviewmodelentry.SetEntityAutocompleteSelectorFactory(
				new EntityAutocompleteSelectorFactory<SubdivisionsJournalViewModel>(
					typeof(Subdivision),
					() => new SubdivisionsJournalViewModel(
						filter,
						UnitOfWorkFactory.GetDefaultFactory,
						ServicesConfig.CommonServices,
						employeeSelectorFactory
					)
				)
			);

			AuthorSubdivisionEntityviewmodelentry.Changed += AuthorSubdivisionEntityviewmodelentryOnChanged;*/
		}

		public void ResetFilter()
		{
			yEnumCMBUndeliveryStatus.SelectedItem = SpecialComboState.All;
			dateperiodOldOrderDate.StartDateOrNull = null;
			dateperiodOldOrderDate.EndDateOrNull = null;
		}

		protected void OnYEnumCMBActionWithInvoiceEnumItemSelected(object sender, Gamma.Widgets.ItemSelectedEventArgs e)
		{
			switch(e.SelectedItem)
			{
				case ActionsWithInvoice.createdNew:
					NewInvoiceCreated = true;
					break;
				case ActionsWithInvoice.notCreated:
					NewInvoiceCreated = false;
					break;
				default:
					NewInvoiceCreated = null;
					break;
			}
			//OnRefiltered();
		}

		public bool? NewInvoiceCreated { get; set; }

		private void AuthorSubdivisionEntityviewmodelentryOnChanged(object sender, EventArgs e)
		{
			//OnRefiltered();
		}
	}
}
