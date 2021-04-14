using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CartPointsAwarded
    {
        public long CartPointsAwardedId { get; set; }
        public long CartFk { get; set; }
        public long VirtueFk { get; set; }
        public int PointsAwarded { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual Virtue VirtueFkNavigation { get; set; }
    }
}
