using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessEmployeeAuthorizationGroupRole
    {
        public long GroupToPartyGroupRoleId { get; set; }
        public long MobileBusinessEmployeeGroupFk { get; set; }
        public long PlatformRoleFk { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployeeAuthorizationGroup MobileBusinessEmployeeGroupFkNavigation { get; set; }
        public virtual PlatformRole PlatformRoleFkNavigation { get; set; }
    }
}
