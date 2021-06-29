using QS.DomainModel.UoW;
using QS.Project.Journal;
using QS.Project.Journal.EntitySelector;
using QS.Project.Services;
using Vodovoz.FilterViewModels.Organization;
using Vodovoz.Journals.JournalViewModels.Organization;

namespace Vodovoz.ViewModels.Journals.JournalFactories
{
	public class SubdivisionJournalFactory : ISubdivisionJournalFactory
	{
		public IEntityAutocompleteSelectorFactory CreateSubdivisionAutocompleteSelectorFactory(IEntityAutocompleteSelectorFactory employeeSelectorFactory, IJournalFilter subdivisionJournaFilter = null)
		{
			return new EntityAutocompleteSelectorFactory<SubdivisionsJournalViewModel>(typeof(Subdivision), () =>
			{
				return new SubdivisionsJournalViewModel((subdivisionJournaFilter as SubdivisionFilterViewModel) ?? new SubdivisionFilterViewModel(), UnitOfWorkFactory.GetDefaultFactory, ServicesConfig.CommonServices, employeeSelectorFactory);
			});
		}
	}
}
