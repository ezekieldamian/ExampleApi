using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationManager
    {
        public long BusinessLocationManagerId { get; set; }
        public long BusinessLocationFk { get; set; }
        public long MobileBusinessEmployeeFk { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
    }
}
