using System;
using NHibernate;
using NHibernate.Transform;
using QS.DomainModel.UoW;
using QS.Project.Domain;
using QS.Project.Journal;
using QS.Services;
using Vodovoz.Domain.Logistic;
using Vodovoz.ViewModels.Journals.FilterViewModels.Logistic;
using Vodovoz.ViewModels.Journals.JournalNodes;
using Vodovoz.ViewModels.ViewModels.Logistic;

namespace Vodovoz.ViewModels.Journals.JournalViewModels.Logistic
{
    public class BreakdownKindJournalViewModel : FilterableSingleEntityJournalViewModelBase
        <BreakdownKind, BreakdownKindViewModel, BreakdownKindNode, BreakdownKindJournalFilterViewModel>
    {
        public BreakdownKindJournalViewModel(
            BreakdownKindJournalFilterViewModel filterViewModel,
            IUnitOfWorkFactory unitOfWorkFactory,
            ICommonServices commonServices)
            : base(filterViewModel, unitOfWorkFactory, commonServices)
        {
            TabName = "Виды поломок автомобилей";
            UpdateOnChanges(typeof(BreakdownKind));
        }

        protected override Func<IUnitOfWork, IQueryOver<BreakdownKind>> ItemsSourceQueryFunction => uow => {
            BreakdownKindNode resultNode = null;
            BreakdownKind breakdownKindAlias = null;

            var query = uow.Session.QueryOver<BreakdownKind>(() => breakdownKindAlias);

            if(FilterViewModel?.IsArchive != null) {
                query.Where(c => c.IsArchive == FilterViewModel.IsArchive);
            }

            query.Where(GetSearchCriterion(
                () => breakdownKindAlias.Id,
                () => breakdownKindAlias.Name
            ));

            var result = query.SelectList(list => list
                    .Select(x => x.Id).WithAlias(() => resultNode.Id)
                    .Select(x => x.IsArchive).WithAlias(() => resultNode.IsArchive)
                    .Select(x => x.Name).WithAlias(() => resultNode.Name))
                .TransformUsing(Transformers.AliasToBean<BreakdownKindNode>());

            return result;
        };
        protected override Func<BreakdownKindViewModel> CreateDialogFunction => () => new BreakdownKindViewModel(
            EntityUoWBuilder.ForCreate(),
            UnitOfWorkFactory,
            commonServices
        );
        protected override Func<BreakdownKindNode, BreakdownKindViewModel> OpenDialogFunction => node => new BreakdownKindViewModel(
            EntityUoWBuilder.ForOpen(node.Id),
            UnitOfWorkFactory,
            commonServices
        );
    }
}
