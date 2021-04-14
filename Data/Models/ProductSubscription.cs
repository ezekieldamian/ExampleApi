using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductSubscription
    {
        public ProductSubscription()
        {
            SubsriptionModification = new HashSet<SubsriptionModification>();
        }

        public long ProductSubscriptionId { get; set; }
        public long CartFk { get; set; }
        public long ProductFk { get; set; }
        public long? DeliveryAddressFk { get; set; }
        public int PeriodicPurchaseRate { get; set; }
        public DateTime? FirstDeliveryDate { get; set; }
        public DateTime BaseDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual PostOfficeAddress DeliveryAddressFkNavigation { get; set; }
        public virtual Product ProductFkNavigation { get; set; }
        public virtual ICollection<SubsriptionModification> SubsriptionModification { get; set; }
    }
}
