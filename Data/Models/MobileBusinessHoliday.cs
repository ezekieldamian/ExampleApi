using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessHoliday
    {
        public long MobileBusinessHolidayId { get; set; }
        public long MobileBusinessFk { get; set; }
        public DateTime? HolidayDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
