using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Prospect
    {
        public long ProspectId { get; set; }
        public long MobileBusinessFk { get; set; }
        public string ProspectType { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual Person ProspectNavigation { get; set; }
    }
}
