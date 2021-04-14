using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusiness
    {
        public MobileBusiness()
        {
            AssetClass = new HashSet<AssetClass>();
            Auction = new HashSet<Auction>();
            AuctionInvitedMobileBusiness = new HashSet<AuctionInvitedMobileBusiness>();
            BusinessLocation = new HashSet<BusinessLocation>();
            BusinessPopUpLocation = new HashSet<BusinessPopUpLocation>();
            Cart = new HashSet<Cart>();
            DimensionSourceMobileBusiness = new HashSet<DimensionSourceMobileBusiness>();
            MobileBusinessAggregatorMobileBusiness = new HashSet<MobileBusinessAggregatorMobileBusiness>();
            MobileBusinessBusinessCategory = new HashSet<MobileBusinessBusinessCategory>();
            MobileBusinessCharity = new HashSet<MobileBusinessCharity>();
            MobileBusinessEmployee = new HashSet<MobileBusinessEmployee>();
            MobileBusinessEmployeeAuthorizationGroup = new HashSet<MobileBusinessEmployeeAuthorizationGroup>();
            MobileBusinessEmployeeOperatingParameters = new HashSet<MobileBusinessEmployeeOperatingParameters>();
            MobileBusinessHighLevelFeatureThresoldScore = new HashSet<MobileBusinessHighLevelFeatureThresoldScore>();
            MobileBusinessHoliday = new HashSet<MobileBusinessHoliday>();
            MobileBusinessHoursOfOperation = new HashSet<MobileBusinessHoursOfOperation>();
            MobileBusinessKeyword = new HashSet<MobileBusinessKeyword>();
            MobileBusinessKpi = new HashSet<MobileBusinessKpi>();
            MobileBusinessPlatformSupportedFormOfPayment = new HashSet<MobileBusinessPlatformSupportedFormOfPayment>();
            MobileBusinessRecruitmentMessage = new HashSet<MobileBusinessRecruitmentMessage>();
            MobileBusinessServiceOperatingParameters = new HashSet<MobileBusinessServiceOperatingParameters>();
            MobileBusinessVirtueRanking = new HashSet<MobileBusinessVirtueRanking>();
            MobileBusinessVirtueScore = new HashSet<MobileBusinessVirtueScore>();
            NotificationEmail = new HashSet<NotificationEmail>();
            PersonAsUser = new HashSet<PersonAsUser>();
            Product = new HashSet<Product>();
            ProductRetailCategory = new HashSet<ProductRetailCategory>();
            Prospect = new HashSet<Prospect>();
            RetailCustomerBadge = new HashSet<RetailCustomerBadge>();
            RetailCustomerBusinessRelationship = new HashSet<RetailCustomerBusinessRelationship>();
            RetailCustomerMobileBusinessAffinity = new HashSet<RetailCustomerMobileBusinessAffinity>();
            RetailCustomerPrepaidCard = new HashSet<RetailCustomerPrepaidCard>();
            RetailCustomerServiceCalendarPreference = new HashSet<RetailCustomerServiceCalendarPreference>();
            RetailCustomerVirtuePoints = new HashSet<RetailCustomerVirtuePoints>();
            ReverseAuctionItem = new HashSet<ReverseAuctionItem>();
            VendorProgramExecutedContract = new HashSet<VendorProgramExecutedContract>();
        }

        public long MobileBusinessId { get; set; }
        public long? OwnerFk { get; set; }
        public long? TaxItemTypeFk { get; set; }
        public long? ReturnAddressFk { get; set; }
        public long? SelectedThemeFk { get; set; }
        public long? SelectedColorFk { get; set; }
        public string OwnerTitle { get; set; }
        public string ActiveFlag { get; set; }
        public decimal? DefaultTradeRadiusInMiles { get; set; }
        public string ShipsGoodsFlag { get; set; }
        public int SophisticationLevel { get; set; }
        public int LifetimeCustomerCount { get; set; }
        public decimal? Configuration { get; set; }
        public decimal RestockingFeeAsARatio { get; set; }
        public int ReferralBonus { get; set; }
        public string LogoUrl { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessOrganization MobileBusinessNavigation { get; set; }
        public virtual Person OwnerFkNavigation { get; set; }
        public virtual PostOfficeAddress ReturnAddressFkNavigation { get; set; }
        public virtual PlatformScreensMainColor SelectedColorFkNavigation { get; set; }
        public virtual PlatformStoreTheme SelectedThemeFkNavigation { get; set; }
        public virtual TaxItemType TaxItemTypeFkNavigation { get; set; }
        [JsonIgnore]
        public virtual AuctionProductSugestion AuctionProductSugestion { get; set; }
        [JsonIgnore]
        public virtual ICollection<AssetClass> AssetClass { get; set; }
        [JsonIgnore]
        public virtual ICollection<Auction> Auction { get; set; }
        [JsonIgnore]
        public virtual ICollection<AuctionInvitedMobileBusiness> AuctionInvitedMobileBusiness { get; set; }
        [JsonIgnore]
        public virtual ICollection<BusinessLocation> BusinessLocation { get; set; }
        [JsonIgnore]
        public virtual ICollection<BusinessPopUpLocation> BusinessPopUpLocation { get; set; }
        [JsonIgnore]
        public virtual ICollection<Cart> Cart { get; set; }
        [JsonIgnore]
        public virtual ICollection<DimensionSourceMobileBusiness> DimensionSourceMobileBusiness { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessAggregatorMobileBusiness> MobileBusinessAggregatorMobileBusiness { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessBusinessCategory> MobileBusinessBusinessCategory { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessCharity> MobileBusinessCharity { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessEmployee> MobileBusinessEmployee { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessEmployeeAuthorizationGroup> MobileBusinessEmployeeAuthorizationGroup { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessEmployeeOperatingParameters> MobileBusinessEmployeeOperatingParameters { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessHighLevelFeatureThresoldScore> MobileBusinessHighLevelFeatureThresoldScore { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessHoliday> MobileBusinessHoliday { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessHoursOfOperation> MobileBusinessHoursOfOperation { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessKeyword> MobileBusinessKeyword { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessKpi> MobileBusinessKpi { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessPlatformSupportedFormOfPayment> MobileBusinessPlatformSupportedFormOfPayment { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessRecruitmentMessage> MobileBusinessRecruitmentMessage { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessServiceOperatingParameters> MobileBusinessServiceOperatingParameters { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessVirtueRanking> MobileBusinessVirtueRanking { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessVirtueScore> MobileBusinessVirtueScore { get; set; }
        [JsonIgnore]
        public virtual ICollection<NotificationEmail> NotificationEmail { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonAsUser> PersonAsUser { get; set; }
        [JsonIgnore]
        public virtual ICollection<Product> Product { get; set; }
        [JsonIgnore]
        public virtual ICollection<ProductRetailCategory> ProductRetailCategory { get; set; }
        [JsonIgnore]
        public virtual ICollection<Prospect> Prospect { get; set; }
        [JsonIgnore]
        public virtual ICollection<RetailCustomerBadge> RetailCustomerBadge { get; set; }
        [JsonIgnore]
        public virtual ICollection<RetailCustomerBusinessRelationship> RetailCustomerBusinessRelationship { get; set; }
        [JsonIgnore]
        public virtual ICollection<RetailCustomerMobileBusinessAffinity> RetailCustomerMobileBusinessAffinity { get; set; }
        [JsonIgnore]
        public virtual ICollection<RetailCustomerPrepaidCard> RetailCustomerPrepaidCard { get; set; }
        [JsonIgnore]
        public virtual ICollection<RetailCustomerServiceCalendarPreference> RetailCustomerServiceCalendarPreference { get; set; }
        [JsonIgnore]
        public virtual ICollection<RetailCustomerVirtuePoints> RetailCustomerVirtuePoints { get; set; }
        [JsonIgnore]
        public virtual ICollection<ReverseAuctionItem> ReverseAuctionItem { get; set; }
        [JsonIgnore]
        public virtual ICollection<VendorProgramExecutedContract> VendorProgramExecutedContract { get; set; }
    }
}
