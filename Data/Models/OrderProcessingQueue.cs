using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class OrderProcessingQueue
    {
        public long OrderPickupQueueId { get; set; }
        public long CartFk { get; set; }
        public long? MobileBusinessEmployeeFk { get; set; }
        public string OrderStatus { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
    }
}
