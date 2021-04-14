using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class DimensionDependentInventoryRecord
    {
        public DimensionDependentInventoryRecord()
        {
            DimensionDependentInventoryRecordDimensionValue = new HashSet<DimensionDependentInventoryRecordDimensionValue>();
        }

        public long DimensionDependentInventoryRecordId { get; set; }
        public long ProductFk { get; set; }
        public int? QuantityOnHand { get; set; }
        public int? QuantityAvailable { get; set; }
        public int? TargetQuantity { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
        public virtual ICollection<DimensionDependentInventoryRecordDimensionValue> DimensionDependentInventoryRecordDimensionValue { get; set; }
    }
}
