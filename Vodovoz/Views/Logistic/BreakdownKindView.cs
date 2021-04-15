﻿using QS.Views.GtkUI;
using Vodovoz.ViewModels.ViewModels.Logistic;

namespace Vodovoz.Views.Logistic
{
    public partial class BreakdownKindView : TabViewBase<BreakdownKindViewModel>
    {
        public BreakdownKindView(BreakdownKindViewModel viewModel) : base(viewModel)
        {
            this.Build();
            ConfigureDlg();
        }

        private void ConfigureDlg()
        {
            yentryName.Binding.AddBinding(ViewModel.Entity, e => e.Name, w => w.Text).InitializeFromSource();

            ycheckIsArchive.Binding.AddBinding(ViewModel.Entity, e => e.IsArchive, w => w.Active).InitializeFromSource();

            buttonSave.Clicked += (sender, e) => ViewModel.SaveAndClose();
            buttonCancel.Clicked += (sender, e) => ViewModel.Close(false, QS.Navigation.CloseSource.Cancel);
        }
    }
}
