using QS.Navigation;
using QS.Services;
using QS.ViewModels;

namespace Vodovoz.ViewModels.Logistic
{
    public sealed class DriverUnscheduledAbsenceViewModel : TabViewModelBase
    {
        public DriverUnscheduledAbsenceViewModel(IInteractiveService interactiveService, INavigationManager navigation = null) : base(interactiveService, navigation)
        { }
    }
}
