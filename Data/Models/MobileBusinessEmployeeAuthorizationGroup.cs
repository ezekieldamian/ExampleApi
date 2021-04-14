using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessEmployeeAuthorizationGroup
    {
        public MobileBusinessEmployeeAuthorizationGroup()
        {
            MobileBusinessEmployeeAuthorizationGroupMembership = new HashSet<MobileBusinessEmployeeAuthorizationGroupMembership>();
            MobileBusinessEmployeeAuthorizationGroupRole = new HashSet<MobileBusinessEmployeeAuthorizationGroupRole>();
        }

        public long MobileBusinessEmployeeAuthorizationGroupId { get; set; }
        public long MobileBuisnessFk { get; set; }
        public string GroupName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBuisnessFkNavigation { get; set; }
        public virtual ICollection<MobileBusinessEmployeeAuthorizationGroupMembership> MobileBusinessEmployeeAuthorizationGroupMembership { get; set; }
        public virtual ICollection<MobileBusinessEmployeeAuthorizationGroupRole> MobileBusinessEmployeeAuthorizationGroupRole { get; set; }
    }
}
