using System;
using QS.Navigation;
using QS.Views.GtkUI;
using Vodovoz.Domain.Logistic;
using Vodovoz.ViewModels.Logistic;

namespace Vodovoz.Views.Logistic
{
    public partial class DriverUnscheduledAbsenceView : TabViewBase<DriverUnscheduledAbsenceViewModel>
    {
        public DriverUnscheduledAbsenceView(DriverUnscheduledAbsenceViewModel viewModel) : base(viewModel)
        {
            Build();
            Configure();
        }

        private void Configure()
        {
            ybuttonCancel.Clicked += (sender, args) => ViewModel.Close(false, CloseSource.Cancel);

            ybuttonAccept.Sensitive = ViewModel.CanEdit;
            ybuttonAccept.Clicked += (sender, args) => ViewModel.AcceptCommand.Execute();

            comboUnscheduledAbsenceReason.ItemsEnum = typeof(UnscheduledAbsenceReason);
            comboUnscheduledAbsenceReason.Binding.AddBinding(ViewModel.EntityToEdit, e => e.UnscheduledAbsenceReason, w => w.SelectedItem)
                .InitializeFromSource();
            comboUnscheduledAbsenceReason.Sensitive = ViewModel.CanEdit;

            datepicker.Binding.AddBinding(ViewModel.EntityToEdit, e => e.DateTime, w => w.Date).InitializeFromSource();
            datepicker.Sensitive = ViewModel.CanEdit;

            ytextComment.Binding.AddBinding(ViewModel.EntityToEdit, e => e.Comment, w => w.Buffer.Text).InitializeFromSource();
            ytextComment.Sensitive = ViewModel.CanEdit;
        }
    }
}
