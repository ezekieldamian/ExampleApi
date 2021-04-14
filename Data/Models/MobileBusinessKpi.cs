using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessKpi
    {
        public long MobileBusinessKpiId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long KpiFk { get; set; }
        public DateTime ElectionDate { get; set; }
        public int TargetPerformanceMeasure { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Kpi KpiFkNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
