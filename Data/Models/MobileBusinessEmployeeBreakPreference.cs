using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessEmployeeBreakPreference
    {
        public long MobileBusinessEmployeeBreakPreferenceId { get; set; }
        public long MobileBusinessEmployeeFk { get; set; }
        public long? WorkBreakCategoryFk { get; set; }
        public int WorkBreakDurationInMinutes { get; set; }
        public int WorkBreakStartTimeMinimum { get; set; }
        public int WorkBreakStartTimeMaximum { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
        public virtual WorkBreakCategory WorkBreakCategoryFkNavigation { get; set; }
    }
}
