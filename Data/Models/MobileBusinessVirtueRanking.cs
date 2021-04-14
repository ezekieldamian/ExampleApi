using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessVirtueRanking
    {
        public long MobileBusinessVirtueRankingId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long VirtueFk { get; set; }
        public string RankingType { get; set; }
        public int? RankOrder { get; set; }
        public decimal? WeightingFactor { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual Virtue VirtueFkNavigation { get; set; }
    }
}
