using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessPopUpLocation
    {
        public long BusinessPopUpLocationId { get; set; }
        public long MobileBusinessFk { get; set; }
        public decimal? DynamicLongitude { get; set; }
        public decimal? DynamicLatitude { get; set; }
        public DateTime? StartTimestamp { get; set; }
        public DateTime? EndTimestamp { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
