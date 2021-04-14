using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerBusinessRelationship
    {
        public long RetailCustomerBusinessRelationshipId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long MobileBusinessFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
