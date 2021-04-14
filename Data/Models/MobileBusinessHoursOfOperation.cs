using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessHoursOfOperation
    {
        public long MobileBusinessHoursOfOperationId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long WeeklyScheduleFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual WeeklySchedule WeeklyScheduleFkNavigation { get; set; }
    }
}
