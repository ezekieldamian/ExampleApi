using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessAggregator
    {
        public MobileBusinessAggregator()
        {
            MobileBusinessAggregatorMobileBusiness = new HashSet<MobileBusinessAggregatorMobileBusiness>();
        }

        public long MobileBusinessAggregatorId { get; set; }
        public int? RevenueShareRatio { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessOrganization MobileBusinessAggregatorNavigation { get; set; }
        public virtual ICollection<MobileBusinessAggregatorMobileBusiness> MobileBusinessAggregatorMobileBusiness { get; set; }
    }
}
