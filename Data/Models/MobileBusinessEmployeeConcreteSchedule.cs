using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessEmployeeConcreteSchedule
    {
        public long MobileBusinessEmployeeConcreteScheduleId { get; set; }
        public long MobileBusinessEmployeeFk { get; set; }
        public long WeeklyScheduleFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
        public virtual WeeklySchedule WeeklyScheduleFkNavigation { get; set; }
    }
}
