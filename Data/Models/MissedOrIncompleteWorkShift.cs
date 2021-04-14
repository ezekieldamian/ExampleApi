using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MissedOrIncompleteWorkShift
    {
        public long MissedOrIncompleteWorkShiftId { get; set; }
        public long MobileBusinessEmployeeFk { get; set; }
        public DateTime WorkScheduleDate { get; set; }
        public DateTime? FailureType { get; set; }
        public string Excuse { get; set; }
        public decimal? ExcuseMitigationFactor { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
    }
}
