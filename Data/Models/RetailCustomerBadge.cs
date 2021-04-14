using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerBadge
    {
        public long RetailCustomerBadgeId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long UniversalBadgeFk { get; set; }
        public long MobileBusinessFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
        public virtual UniversalBadge UniversalBadgeFkNavigation { get; set; }
    }
}
