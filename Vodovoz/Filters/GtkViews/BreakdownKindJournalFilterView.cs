using System;
using QS.Views.GtkUI;
using Vodovoz.CommonEnums;
using Vodovoz.Infrastructure.Converters;
using Vodovoz.ViewModels.Journals.FilterViewModels.Logistic;

namespace Vodovoz.Filters.GtkViews
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class BreakdownKindJournalFilterView  : FilterViewBase<BreakdownKindJournalFilterViewModel>
    {
        public BreakdownKindJournalFilterView(BreakdownKindJournalFilterViewModel filterViewModel) : base(filterViewModel)
        {
            this.Build();
            comboShowArchive.ItemsEnum = typeof(AllYesNo);
            comboShowArchive.Binding.AddBinding(ViewModel, vm => vm.IsArchive, w => w.SelectedItem,
                new NullableBoolToAllYesNoConverter()).InitializeFromSource();
        }
    }
}
