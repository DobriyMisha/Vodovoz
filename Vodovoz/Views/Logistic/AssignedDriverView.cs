using QS.Navigation;
using QS.Views.GtkUI;
using Vodovoz.ViewModels.ViewModels.Logistic;

namespace Vodovoz.Views.Logistic
{
    public partial class AssignedDriverView : TabViewBase<AssignedDriverViewModel>
    {
        public AssignedDriverView(AssignedDriverViewModel viewModel) : base(viewModel)
        {
            this.Build();
            Configure();
        }

        private void Configure()
        {
            ybuttonCancel.Clicked += (sender, args) => ViewModel.Close(false, CloseSource.Cancel);

            ybuttonAccept.Sensitive = ViewModel.CanEdit;
            ybuttonAccept.Clicked += (sender, args) => ViewModel.AcceptCommand.Execute();

            entryDriver.SetEntityAutocompleteSelectorFactory(ViewModel.EntityAutocompleteSelectorFactory);
            entryDriver.Binding.AddBinding(ViewModel.EntityToEdit, e => e.Driver, w => w.Subject)
                .InitializeFromSource();
            entryDriver.Sensitive = ViewModel.CanEdit;

            datepicker.Binding.AddBinding(ViewModel.EntityToEdit, e => e.StartDate, w => w.StartDate).InitializeFromSource();
            datepicker.Binding.AddBinding(ViewModel.EntityToEdit, e => e.EndDate, w => w.EndDate).InitializeFromSource();
            datepicker.Sensitive = ViewModel.CanEdit;
        }
    }
}
