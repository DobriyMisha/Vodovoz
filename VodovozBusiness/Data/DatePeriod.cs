using System;

namespace Vodovoz.Data
{
    public struct DatePeriod
    {
        public DatePeriod(DateTime startDate = default(DateTime), DateTime endDate = default(DateTime))
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTime StartDate;
        public DateTime EndDate;
    }
}
