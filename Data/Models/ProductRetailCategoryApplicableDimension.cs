using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductRetailCategoryApplicableDimension
    {
        public long ProductRetailCategoryApplicableDimensionId { get; set; }
        public long ProductRetailCategoryFk { get; set; }
        public long DimensionFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Dimension DimensionFkNavigation { get; set; }
        public virtual ProductRetailCategory ProductRetailCategoryFkNavigation { get; set; }
    }
}
