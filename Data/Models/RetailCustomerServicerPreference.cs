using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerServicerPreference
    {
        public long RetailCustomerServicePreferenceId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long MobileBusinessEmployeeFk { get; set; }
        public long? ProductRetailCategoryFk { get; set; }
        public long? ProfessionalServiceFk { get; set; }
        public DateTime StartTimestamp { get; set; }
        public DateTime? EndTimestamp { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
        public virtual ProductRetailCategory ProductRetailCategoryFkNavigation { get; set; }
        public virtual ProfessionalService ProfessionalServiceFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
