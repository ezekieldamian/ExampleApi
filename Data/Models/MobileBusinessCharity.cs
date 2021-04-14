using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessCharity
    {
        public long MobileBusinessCharityId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long CharityFk { get; set; }
        public decimal SpecifiedMatchRatio { get; set; }
        public decimal MobileBusinessMatchMaxPortionOfCartTotal { get; set; }
        public string ActiveFlag { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Charity CharityFkNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
