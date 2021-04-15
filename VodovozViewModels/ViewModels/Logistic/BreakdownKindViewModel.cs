using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Project.Domain;
using QS.Services;
using QS.ViewModels;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.ViewModels.ViewModels.Logistic
{
    public sealed class BreakdownKindViewModel : EntityTabViewModelBase<BreakdownKind>
    {
        public BreakdownKindViewModel(
            IEntityUoWBuilder uowBuilder,
            IUnitOfWorkFactory unitOfWorkFactory,
            ICommonServices commonServices,
            INavigationManager navigation = null)
            : base(uowBuilder, unitOfWorkFactory, commonServices, navigation)
        {
            TabName = Entity?.Id == 0 ? "Новый вид поломки автомобиля" : Entity?.Name;
        }
    }
}
