using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerCharibleContribution
    {
        public long RetailCustomerCharibleContributionId { get; set; }
        public long CartFk { get; set; }
        public long CharityFk { get; set; }
        public decimal RetailCustomerContributionAmount { get; set; }
        public decimal PlatformMatchAmount { get; set; }
        public decimal MobileBusinessMatchAmount { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual Charity CharityFkNavigation { get; set; }
    }
}
