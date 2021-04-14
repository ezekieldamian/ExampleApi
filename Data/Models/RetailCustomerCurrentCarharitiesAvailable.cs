using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerCurrentCarharitiesAvailable
    {
        public long RetailCustomerCurrentCarharitiesAvailableId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long CharityFk { get; set; }
        public long OrderOfAppearance { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Charity CharityFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
