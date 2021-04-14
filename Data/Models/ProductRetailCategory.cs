using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductRetailCategory
    {
        public ProductRetailCategory()
        {
            InverseParentProductRetailCategoryFkNavigation = new HashSet<ProductRetailCategory>();
            MobileBusinessEmployeeServiceQualification = new HashSet<MobileBusinessEmployeeServiceQualification>();
            Product = new HashSet<Product>();
            ProductRetailCategoryApplicableDimension = new HashSet<ProductRetailCategoryApplicableDimension>();
            ProductRetailCategoryTag = new HashSet<ProductRetailCategoryTag>();
            Recommendation = new HashSet<Recommendation>();
            RetailCustomerServiceCalendarPreference = new HashSet<RetailCustomerServiceCalendarPreference>();
            RetailCustomerServiceLocationPreference = new HashSet<RetailCustomerServiceLocationPreference>();
            RetailCustomerServiceSpecialDuration = new HashSet<RetailCustomerServiceSpecialDuration>();
            RetailCustomerServicerPreference = new HashSet<RetailCustomerServicerPreference>();
            TrustedTradePromptProductRetailCategory = new HashSet<TrustedTradePromptProductRetailCategory>();
        }

        public long ProductRetailCategoryId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long? ParentProductRetailCategoryFk { get; set; }
        public long? TaxItemTypeFk { get; set; }
        public long? ReturnAddressFk { get; set; }
        public string CategoryName { get; set; }
        public string RefundAndReturnPolicyGraphic { get; set; }
        public decimal RestockingFeeAsARatio { get; set; }
        public string WhoPaysShipping { get; set; }
        public int? NormalServiceDurationInMinutes { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual ProductRetailCategory ParentProductRetailCategoryFkNavigation { get; set; }
        public virtual PostOfficeAddress ReturnAddressFkNavigation { get; set; }
        public virtual TaxItemType TaxItemTypeFkNavigation { get; set; }
        public virtual ICollection<ProductRetailCategory> InverseParentProductRetailCategoryFkNavigation { get; set; }
        public virtual ICollection<MobileBusinessEmployeeServiceQualification> MobileBusinessEmployeeServiceQualification { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductRetailCategoryApplicableDimension> ProductRetailCategoryApplicableDimension { get; set; }
        public virtual ICollection<ProductRetailCategoryTag> ProductRetailCategoryTag { get; set; }
        public virtual ICollection<Recommendation> Recommendation { get; set; }
        public virtual ICollection<RetailCustomerServiceCalendarPreference> RetailCustomerServiceCalendarPreference { get; set; }
        public virtual ICollection<RetailCustomerServiceLocationPreference> RetailCustomerServiceLocationPreference { get; set; }
        public virtual ICollection<RetailCustomerServiceSpecialDuration> RetailCustomerServiceSpecialDuration { get; set; }
        public virtual ICollection<RetailCustomerServicerPreference> RetailCustomerServicerPreference { get; set; }
        public virtual ICollection<TrustedTradePromptProductRetailCategory> TrustedTradePromptProductRetailCategory { get; set; }
    }
}
