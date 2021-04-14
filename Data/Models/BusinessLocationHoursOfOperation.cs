using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationHoursOfOperation
    {
        public long BusinessLocationHoursOfOperationId { get; set; }
        public long BusinessLocationFk { get; set; }
        public long WeeklyScheduleFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual WeeklySchedule WeeklyScheduleFkNavigation { get; set; }
    }
}
