using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductApplicableDimension
    {
        public long ProductProductDimesionId { get; set; }
        public long ProductFk { get; set; }
        public long DimensionFk { get; set; }
        public long? DefaultDimensionValueFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual DimensionValue DefaultDimensionValueFkNavigation { get; set; }
        public virtual Dimension DimensionFkNavigation { get; set; }
        public virtual Product ProductFkNavigation { get; set; }
    }
}
