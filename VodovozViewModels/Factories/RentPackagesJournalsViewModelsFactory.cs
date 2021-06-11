using System;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Project.Journal;
using QS.Project.Services;
using QS.Services;
using Vodovoz.ViewModels.Journals.JournalViewModels.Rent;

namespace Vodovoz.Factories
{
    public class RentPackagesJournalsViewModelsFactory : IRentPackagesJournalsViewModelsFactory
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly ICommonServices _commonServices;
        private readonly INavigationManager _navigationManager;
        private readonly IDeleteEntityService _deleteEntityService;

        public RentPackagesJournalsViewModelsFactory(
            IUnitOfWorkFactory uowFactory,
            ICommonServices commonServices,
            INavigationManager navigationManager,
            IDeleteEntityService deleteEntityService = null)
        {
            _uowFactory = uowFactory ?? throw new ArgumentNullException(nameof(uowFactory));
            _commonServices = commonServices ?? throw new ArgumentNullException(nameof(commonServices));
            _navigationManager = navigationManager ?? throw new ArgumentNullException(nameof(navigationManager));
            _deleteEntityService = deleteEntityService;
        }

        public PaidRentPackagesJournalViewModel CreatePaidRentPackagesJournalViewModel(
            bool multipleSelect = false, bool isCreateVisible = true, bool isEditVisible = true, bool isDeleteVisible = true)
        {
            var journal = new PaidRentPackagesJournalViewModel(_uowFactory, _commonServices, _navigationManager, _deleteEntityService)
            {
                SelectionMode = multipleSelect == false
                    ? JournalSelectionMode.Single
                    : JournalSelectionMode.Multiple,
                VisibleCreateAction = isCreateVisible,
                VisibleEditAction = isEditVisible,
                VisibleDeleteAction = isDeleteVisible
            };

            return journal;
        }
        
        public FreeRentPackagesJournalViewModel CreateFreeRentPackagesJournalViewModel(
            bool multipleSelect = false, bool isCreateVisible = true, bool isEditVisible = true, bool isDeleteVisible = true)
        {
            var journal = new FreeRentPackagesJournalViewModel(_uowFactory, _commonServices, _navigationManager, _deleteEntityService)
            {
                SelectionMode = multipleSelect == false
                    ? JournalSelectionMode.Single
                    : JournalSelectionMode.Multiple,
                VisibleCreateAction = isCreateVisible,
                VisibleEditAction = isEditVisible,
                VisibleDeleteAction = isDeleteVisible
            };

            return journal;
        }
    }
}
