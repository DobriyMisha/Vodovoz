﻿using System;
using System.Collections.Generic;
using System.Linq;
using QS.DomainModel.UoW;
using QS.Project.Domain;
using QS.Project.Journal.EntitySelector;
using QS.Project.Services;
using QS.Services;
using QS.ViewModels;
using Vodovoz.Domain.Complaints;
using Vodovoz.Domain.Employees;
using Vodovoz.EntityRepositories.Subdivisions;
using Vodovoz.Infrastructure.Services;

namespace Vodovoz.ViewModels.Complaints
{
	public class CreateInnerComplaintViewModel : EntityTabViewModelBase<Complaint>
	{
		private readonly IEmployeeService employeeService;
		private readonly ISubdivisionRepository subdivisionRepository;
		readonly IEntityAutocompleteSelectorFactory employeeSelectorFactory;
        private readonly IFilePickerService filePickerService;

        public CreateInnerComplaintViewModel(
			IEntityUoWBuilder uoWBuilder,
			IUnitOfWorkFactory unitOfWorkFactory,
			IEmployeeService employeeService,
			ISubdivisionRepository subdivisionRepository,
			ICommonServices commonServices,
			IEntityAutocompleteSelectorFactory employeeSelectorFactory,
            IFilePickerService filePickerService
            ) : base(uoWBuilder, unitOfWorkFactory, commonServices)
		{
            this.filePickerService = filePickerService ?? throw new ArgumentNullException(nameof(filePickerService));
            this.employeeSelectorFactory = employeeSelectorFactory ?? throw new ArgumentNullException(nameof(employeeSelectorFactory));
			this.employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
			this.subdivisionRepository = subdivisionRepository ?? throw new ArgumentNullException(nameof(subdivisionRepository));
			Entity.ComplaintType = ComplaintType.Inner;
			Entity.SetStatus(ComplaintStatuses.Checking);
			TabName = "Новая внутреняя рекламация";
		}

		//так как диалог только для создания рекламации
		public bool CanEdit => PermissionResult.CanCreate;

		private Employee currentEmployee;
		public Employee CurrentEmployee {
			get {
				if(currentEmployee == null) {
					currentEmployee = employeeService.GetEmployeeForUser(UoW, UserService.CurrentUserId);
				}
				return currentEmployee;
			}
		}

		List<ComplaintKind> complaintKindSource;
		public IEnumerable<ComplaintKind> ComplaintKindSource {
			get {
				if(complaintKindSource == null)
					complaintKindSource = UoW.GetAll<ComplaintKind>().Where(k => !k.IsArchive).ToList();
				if(Entity.ComplaintKind != null && Entity.ComplaintKind.IsArchive)
					complaintKindSource.Add(UoW.GetById<ComplaintKind>(Entity.ComplaintKind.Id));

				return complaintKindSource;
			}
		}

		private GuiltyItemsViewModel guiltyItemsViewModel;
		public GuiltyItemsViewModel GuiltyItemsViewModel {
			get {
				if(guiltyItemsViewModel == null) {
					guiltyItemsViewModel = new GuiltyItemsViewModel(Entity, UoW, CommonServices, subdivisionRepository, employeeSelectorFactory);
				}

				return guiltyItemsViewModel;
			}
		}

        private ComplaintFilesViewModel filesViewModel;
        public ComplaintFilesViewModel FilesViewModel
        {
            get
            {
                if (filesViewModel == null)
                {
                    filesViewModel = new ComplaintFilesViewModel(Entity, UoW, filePickerService, CommonServices);
                }
                return filesViewModel;
            }
        }

        protected override void BeforeValidation()
		{
			if(UoW.IsNew) {
				Entity.CreatedBy = CurrentEmployee;
				Entity.CreationDate = DateTime.Now;
				Entity.PlannedCompletionDate = DateTime.Today;
			}
			Entity.ChangedBy = CurrentEmployee;
			Entity.ChangedDate = DateTime.Now;

			base.BeforeValidation();
		}
	}
}
