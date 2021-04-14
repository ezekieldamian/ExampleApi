using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class WorkBreakCategory
    {
        public WorkBreakCategory()
        {
            MobileBusinessEmployeeBreakPreference = new HashSet<MobileBusinessEmployeeBreakPreference>();
        }

        public long WorkBreakCategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<MobileBusinessEmployeeBreakPreference> MobileBusinessEmployeeBreakPreference { get; set; }
    }
}
