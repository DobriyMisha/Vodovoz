using QS.Project.Journal;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.ViewModels.Journals.JournalNodes
{
    public class BreakdownKindNode : JournalEntityNodeBase<BreakdownKind>
    {
        public string Name { get; set; }
        public bool IsArchive { get; set; }
    }
}
