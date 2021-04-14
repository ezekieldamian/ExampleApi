using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class GoodVendorOrder
    {
        public long GoodVendorOrderId { get; set; }
        public long GoodFk { get; set; }
        public long SupplierFk { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? FulfillmentDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Good GoodFkNavigation { get; set; }
        public virtual BusinessOrganization SupplierFkNavigation { get; set; }
    }
}
