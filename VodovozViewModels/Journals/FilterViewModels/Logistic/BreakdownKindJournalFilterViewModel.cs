using QS.Project.Filter;

namespace Vodovoz.ViewModels.Journals.FilterViewModels.Logistic
{
    public class BreakdownKindJournalFilterViewModel : FilterViewModelBase<BreakdownKindJournalFilterViewModel>
    {
        private bool? isArchive;
        public virtual bool? IsArchive {
            get => isArchive;
            set => UpdateFilterField(ref isArchive, value);
        }
    }
}
