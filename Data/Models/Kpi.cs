using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Kpi
    {
        public Kpi()
        {
            MobileBusinessKpi = new HashSet<MobileBusinessKpi>();
        }

        public long KpiId { get; set; }
        public string TextDescription { get; set; }
        public string LevelIndicator { get; set; }
        public string DefaultFlag { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<MobileBusinessKpi> MobileBusinessKpi { get; set; }
    }
}
