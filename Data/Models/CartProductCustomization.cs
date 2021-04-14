using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CartProductCustomization
    {
        public long CartProductCustomizationId { get; set; }
        public long CartProductFk { get; set; }
        public long DimensionOfCustomizationFk { get; set; }
        public long ProductDimensionValueFk { get; set; }
        public string CustomText { get; set; }
        public string CustomGraphic { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual CartProduct CartProductFkNavigation { get; set; }
    }
}
