using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductQuantityDiscount
    {
        public long ProductQuantityDiscountId { get; set; }
        public long ProductFk { get; set; }
        public int QualifyingQuantity { get; set; }
        public decimal? ReducedPriceForTheSet { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
    }
}
