﻿using System;
using System.Collections.Generic;
using System.Data.Bindings.Collections.Generic;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.Domain.Employees
{
	public interface IEmployee : IPersonnel
	{
		EmployeeCategory Category { get; set; }
		string AndroidLogin { get; set; }
		string AndroidPassword { get; set; }
		string AndroidSessionKey { get; set; }
		string AndroidToken { get; set; }
		EmployeeStatus Status { get; set; }
		User User { get; set; }
		Subdivision Subdivision { get; set; }
		DateTime? FirstWorkDay { get; set; }
		Employee DefaultForwarder { get; set; }
		bool LargusDriver { get; set; }
		CarTypeOfUse? DriverOf { get; set; }
		float DriverSpeed { get; set; }
		short TripPriority { get; set; }
		bool VisitingMaster { get; set; }
		
		IList<DriverDistrictPrioritySet> DriverDistrictPrioritySets { get; set; }
		IList<DriverWorkScheduleSet> DriverWorkScheduleSets { get; set; }
		IList<DriverUnscheduledAbsence> DriverUnscheduledAbsences { get; set; }
		GenericObservableList<DriverDistrictPrioritySet> ObservableDriverDistrictPrioritySets { get; }
		GenericObservableList<DriverWorkScheduleSet> ObservableDriverWorkScheduleSets { get; }
		GenericObservableList<DriverUnscheduledAbsence> ObservableDriverUnscheduledAbsences { get; }

		double TimeCorrection(long timeValue);
	}
}
