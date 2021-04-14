using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Wishlist
    {
        public long WishlistId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long ProductFk { get; set; }
        public DateTime DateAdded { get; set; }
        public int? QuantityDesired { get; set; }
        public int? ExlicitImplicitIndicator { get; set; }
        public string ActiveFlag { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
