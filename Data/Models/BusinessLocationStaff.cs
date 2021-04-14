using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationStaff
    {
        public long BusinessLocationStaffId { get; set; }
        public long BusinessLocationFk { get; set; }
        public long MobileBusinessEmployeeFk { get; set; }
        public string LocationStatus { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
    }
}
