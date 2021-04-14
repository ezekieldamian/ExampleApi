using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessAggregatorMobileBusiness
    {
        public long MobileBusinessAggregatorMobileBusinessId { get; set; }
        public long MobileBusinessAggregatorFk { get; set; }
        public long MobileBusinessFk { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessAggregator MobileBusinessAggregatorFkNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
