using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RestockEvent
    {
        public long RestockEventId { get; set; }
        public long ProductFk { get; set; }
        public long MobileBusinessEmployeeFk { get; set; }
        public int NewQuantity { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
        public virtual Product ProductFkNavigation { get; set; }
    }
}
