using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerServiceCalendarPreference
    {
        public long RetailCustomerServiceCalendarPreferenceId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long MobileBusinessFk { get; set; }
        public long? ProductRetailCategoryFk { get; set; }
        public long? ServiceFk { get; set; }
        public string DayOfWeek { get; set; }
        public string TimeOfDay { get; set; }
        public int? PreferedTimeAsExactMinutesAfterGrinageMidnight { get; set; }
        public int PreferenceOrder { get; set; }
        public DateTime StartTimestamp { get; set; }
        public DateTime? EndTimestamp { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual ProductRetailCategory ProductRetailCategoryFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
        public virtual ProfessionalService ServiceFkNavigation { get; set; }
    }
}
