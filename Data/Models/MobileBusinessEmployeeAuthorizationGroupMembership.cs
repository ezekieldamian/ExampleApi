using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessEmployeeAuthorizationGroupMembership
    {
        public long MobileBusinessEmployeeAuthorizationGroupMembershipId { get; set; }
        public long EmployeeGroupFk { get; set; }
        public long MobileBusinessEmployeeFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployeeAuthorizationGroup EmployeeGroupFkNavigation { get; set; }
        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
    }
}
