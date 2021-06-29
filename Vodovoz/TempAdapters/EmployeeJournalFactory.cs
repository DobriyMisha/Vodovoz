using QS.DomainModel.UoW;
using QS.Project.Journal;
using QS.Project.Journal.EntitySelector;
using QS.Project.Services;
using Vodovoz.Domain.Employees;
using Vodovoz.Filters.ViewModels;
using Vodovoz.JournalViewModels;

namespace Vodovoz.TempAdapters
{
	public class EmployeeJournalFactory : IEmployeeJournalFactory
	{
		public IEntityAutocompleteSelectorFactory CreateEmployeeAutocompleteSelectorFactory(IJournalFilter employeeJournalFilter = null)
		{
			return new EntityAutocompleteSelectorFactory<EmployeesJournalViewModel>(typeof(Employee), () =>
			{
				return new EmployeesJournalViewModel((employeeJournalFilter as EmployeeFilterViewModel) ?? new EmployeeFilterViewModel(),
					UnitOfWorkFactory.GetDefaultFactory, ServicesConfig.CommonServices);
			});
		}
	}
}