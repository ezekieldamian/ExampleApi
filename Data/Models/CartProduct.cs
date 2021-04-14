using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CartProduct
    {
        public CartProduct()
        {
            CartProductCustomization = new HashSet<CartProductCustomization>();
        }

        public long CartProductId { get; set; }
        public long CartFk { get; set; }
        public long ProductFk { get; set; }
        public int? OrderQuantity { get; set; }
        public decimal Price { get; set; }
        public string SpecificationDetails { get; set; }
        public int CustomizationSequenceNumber { get; set; }
        public long? PickupOrShipIndication { get; set; }
        public int? OfferTag { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual Product ProductFkNavigation { get; set; }
        public virtual CartProductServiceDetail CartProductServiceDetail { get; set; }
        public virtual ICollection<CartProductCustomization> CartProductCustomization { get; set; }
    }
}
