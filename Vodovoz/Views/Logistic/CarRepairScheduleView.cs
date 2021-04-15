using QS.Navigation;
using QS.Views.GtkUI;
using Vodovoz.ViewModels.ViewModels.Logistic;

namespace Vodovoz.Views.Logistic
{
    public partial class CarRepairScheduleView : TabViewBase<CarRepairScheduleViewModel>
    {
        public CarRepairScheduleView(CarRepairScheduleViewModel viewModel) : base(viewModel)
        {
            this.Build();
            Configure();
        }

        private void Configure()
        {
            ybuttonCancel.Clicked += (sender, args) => ViewModel.Close(false, CloseSource.Cancel);

            ybuttonAccept.Sensitive = ViewModel.CanEdit;
            ybuttonAccept.Clicked += (sender, args) => ViewModel.AcceptCommand.Execute();

            comboBreakdownKind.ItemsList = ViewModel.BreakdownKinds;
            comboBreakdownKind.Binding.AddBinding(ViewModel.EntityToEdit, e => e.BreakdownKind, w => w.SelectedItem).InitializeFromSource();
            comboBreakdownKind.Sensitive = ViewModel.CanEdit;

            datepicker.Binding.AddBinding(ViewModel.EntityToEdit, e => e.StartDate, w => w.StartDate).InitializeFromSource();
            datepicker.Binding.AddBinding(ViewModel.EntityToEdit, e => e.EndDate, w => w.EndDate).InitializeFromSource();
            datepicker.Sensitive = ViewModel.CanEdit;

            ytextComment.Binding.AddBinding(ViewModel.EntityToEdit, e => e.Comment, w => w.Buffer.Text).InitializeFromSource();
            ytextComment.Sensitive = ViewModel.CanEdit;
        }
    }
}
