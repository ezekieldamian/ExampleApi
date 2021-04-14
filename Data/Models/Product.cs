using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            AuctionItem = new HashSet<AuctionItem>();
            AuctionProductSugestion = new HashSet<AuctionProductSugestion>();
            CartProduct = new HashSet<CartProduct>();
            DimensionDependentInventoryRecord = new HashSet<DimensionDependentInventoryRecord>();
            ProductApplicableDimension = new HashSet<ProductApplicableDimension>();
            ProductCustomerReview = new HashSet<ProductCustomerReview>();
            ProductImage = new HashSet<ProductImage>();
            ProductQuantityDiscount = new HashSet<ProductQuantityDiscount>();
            ProductSubscription = new HashSet<ProductSubscription>();
            ProductTag = new HashSet<ProductTag>();
            ProductTerms = new HashSet<ProductTerms>();
            ProductVirtuePointCredit = new HashSet<ProductVirtuePointCredit>();
            Recommendation = new HashSet<Recommendation>();
            RestockEvent = new HashSet<RestockEvent>();
            RestockRequirement = new HashSet<RestockRequirement>();
            TrustedTradePromptProduct = new HashSet<TrustedTradePromptProduct>();
            UniversalItemSource = new HashSet<UniversalItemSource>();
            Wishlist = new HashSet<Wishlist>();
        }

        public long ProductId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long? ProductRetailCategoryFk { get; set; }
        public long? TaxItemTypeFk { get; set; }
        public string TextDescription { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal? MaximumPrice { get; set; }
        public int LoyaltyPointsToAccrue { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? CommissionRate { get; set; }
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
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }
        public string PictureUrl { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual ProductRetailCategory ProductRetailCategoryFkNavigation { get; set; }
        public virtual TaxItemType TaxItemTypeFkNavigation { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual Good Good { get; set; }
        public virtual ProfessionalService ProfessionalService { get; set; }
        public virtual ICollection<AuctionItem> AuctionItem { get; set; }
        public virtual ICollection<AuctionProductSugestion> AuctionProductSugestion { get; set; }
        public virtual ICollection<CartProduct> CartProduct { get; set; }
        public virtual ICollection<DimensionDependentInventoryRecord> DimensionDependentInventoryRecord { get; set; }
        public virtual ICollection<ProductApplicableDimension> ProductApplicableDimension { get; set; }
        public virtual ICollection<ProductCustomerReview> ProductCustomerReview { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
        public virtual ICollection<ProductQuantityDiscount> ProductQuantityDiscount { get; set; }
        public virtual ICollection<ProductSubscription> ProductSubscription { get; set; }
        public virtual ICollection<ProductTag> ProductTag { get; set; }
        public virtual ICollection<ProductTerms> ProductTerms { get; set; }
        public virtual ICollection<ProductVirtuePointCredit> ProductVirtuePointCredit { get; set; }
        public virtual ICollection<Recommendation> Recommendation { get; set; }
        public virtual ICollection<RestockEvent> RestockEvent { get; set; }
        public virtual ICollection<RestockRequirement> RestockRequirement { get; set; }
        public virtual ICollection<TrustedTradePromptProduct> TrustedTradePromptProduct { get; set; }
        public virtual ICollection<UniversalItemSource> UniversalItemSource { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
