using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationInventoryDimensionValue
    {
        public long BusinessLocationInventoryDimensionValueId { get; set; }
        public long BusinessLocationInventoryFk { get; set; }
        public long DimensionValueFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocationInventory BusinessLocationInventoryFkNavigation { get; set; }
        public virtual DimensionValue DimensionValueFkNavigation { get; set; }
    }
}
