using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Dimension
    {
        public Dimension()
        {
            DimensionCreatorManufacturer = new HashSet<DimensionCreatorManufacturer>();
            DimensionSourceBusinessCategory = new HashSet<DimensionSourceBusinessCategory>();
            DimensionSourceMobileBusiness = new HashSet<DimensionSourceMobileBusiness>();
            DimensionValue = new HashSet<DimensionValue>();
            ProductApplicableDimension = new HashSet<ProductApplicableDimension>();
            ProductRetailCategoryApplicableDimension = new HashSet<ProductRetailCategoryApplicableDimension>();
        }

        public long DimensionId { get; set; }
        public int? DefaultDimensionValueFk { get; set; }
        public string DimensionName { get; set; }
        public string GraphicGuide { get; set; }
        public string CustomizationFlag { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<DimensionCreatorManufacturer> DimensionCreatorManufacturer { get; set; }
        public virtual ICollection<DimensionSourceBusinessCategory> DimensionSourceBusinessCategory { get; set; }
        public virtual ICollection<DimensionSourceMobileBusiness> DimensionSourceMobileBusiness { get; set; }
        public virtual ICollection<DimensionValue> DimensionValue { get; set; }
        public virtual ICollection<ProductApplicableDimension> ProductApplicableDimension { get; set; }
        public virtual ICollection<ProductRetailCategoryApplicableDimension> ProductRetailCategoryApplicableDimension { get; set; }
    }
}
