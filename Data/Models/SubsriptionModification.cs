using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class SubsriptionModification
    {
        public long SubscriptionModificationId { get; set; }
        public long ProductSubscriptionFk { get; set; }
        public decimal? NewPrice { get; set; }
        public int PeriodicPurchaseRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ProductSubscription ProductSubscriptionFkNavigation { get; set; }
    }
}
