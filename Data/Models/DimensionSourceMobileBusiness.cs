using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class DimensionSourceMobileBusiness
    {
        public long DimensionSourceMobileBusinessId { get; set; }
        public long DimensionFk { get; set; }
        public long MobileBusinessFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Dimension DimensionFkNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
