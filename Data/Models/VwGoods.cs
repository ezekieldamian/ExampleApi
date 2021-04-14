using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VwGoods
    {
        public long MobileBusinessFk { get; set; }
        public long? TaxItemTypeFk { get; set; }
        public string TextDescription { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal? MaximumPrice { get; set; }
        public int LoyaltyPointsToAccrue { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public decimal? CommissionAmount { get; set; }
        public string UnitOfMeasure { get; set; }
        public string PhysicalOrVirtualIndicator { get; set; }
        public string VisableFlag { get; set; }
        public string DefaultPurchaseMode { get; set; }
        public string OkForPickupFlag { get; set; }
        public string OkForDeliveryFlag { get; set; }
        public string OkForShipFlag { get; set; }
        public int? ServiceLifeInDays { get; set; }
        public int? ServiceLifeExactOrCategoryFlag { get; set; }
        public decimal CommissionRatio { get; set; }
        public int QuantityAvailable { get; set; }
        public int? QuantityOnHand { get; set; }
        public string PlatformGetsAllInventoryFlag { get; set; }
    }
}
