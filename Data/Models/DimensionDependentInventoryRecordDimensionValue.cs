using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class DimensionDependentInventoryRecordDimensionValue
    {
        public long DimensionalDependentInventoryRecordDimensionValueId { get; set; }
        public long DimensionalDependentInventoryRecordFk { get; set; }
        public long ProductDimensionalValueFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual DimensionDependentInventoryRecord DimensionalDependentInventoryRecordFkNavigation { get; set; }
        public virtual DimensionValue ProductDimensionalValueFkNavigation { get; set; }
    }
}
