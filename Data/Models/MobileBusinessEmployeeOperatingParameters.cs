using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessEmployeeOperatingParameters
    {
        public long MobileBusinessServiceOperatingParametersId { get; set; }
        public long MobileBusinessFk { get; set; }
        public int? LocationAssignmentMethod { get; set; }
        public int? SchedulingOfHoursMethod { get; set; }
        public int EmployeeDefaultLoyaltyPoints { get; set; }
        public int EmployeeWorkDayNoShowLoyaltyPenalty { get; set; }
        public int EmployeeWorkDayLateshowOrEarlyLeavePenalty { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
