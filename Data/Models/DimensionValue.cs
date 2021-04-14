using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class DimensionValue
    {
        public DimensionValue()
        {
            BusinessLocationInventoryDimensionValue = new HashSet<BusinessLocationInventoryDimensionValue>();
            DimensionDependentInventoryRecordDimensionValue = new HashSet<DimensionDependentInventoryRecordDimensionValue>();
            ProductApplicableDimension = new HashSet<ProductApplicableDimension>();
        }

        public long DimensionValueId { get; set; }
        public long DimensionFk { get; set; }
        public string OptionValue { get; set; }
        public string OptionGraphic { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Dimension DimensionFkNavigation { get; set; }
        public virtual ICollection<BusinessLocationInventoryDimensionValue> BusinessLocationInventoryDimensionValue { get; set; }
        public virtual ICollection<DimensionDependentInventoryRecordDimensionValue> DimensionDependentInventoryRecordDimensionValue { get; set; }
        public virtual ICollection<ProductApplicableDimension> ProductApplicableDimension { get; set; }
    }
}
