using Empr.CoreServicesApi.Models.DTO.Update;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO
{
    public partial class MobileBusinessDto
    {
        public long MobileBusinessId { get; set; }
        public long? OwnerFk { get; set; }
        public long? MonthlyVolumeBracketFk { get; set; }
        public long TaxItemTypeFk { get; set; }
        public long? ReturnAddressFk { get; set; }
        public long? SelectedThemeFk { get; set; }
        public long? SelectedColorFk { get; set; }
        public long? ServiceAreaBracketFk { get; set; }
        public string OwnerTitle { get; set; }
        public string ActiveFlag { get; set; }
        public decimal? DefaultTradeRadiusInMiles { get; set; }
        public string OffersGoodsFlag { get; set; }
        public string OffersServicesFlag { get; set; }
        public string OffersAssetsFlag { get; set; }
        public string ShipsGoodsFlag { get; set; }
        public string AcceptsCreditCardFlag { get; set; }
        public string AcceptsAchFlag { get; set; }
        public int SophisticationLevel { get; set; }
        public int LifetimeCustomerCount { get; set; }
        public decimal? Configuration { get; set; }
        public decimal RestockingFeeAsARatio { get; set; }
        public int ReferralBonus { get; set; }
        public string BusinessUrl { get; set; }

        public string LogoUrl { get; set; }

        [JsonIgnore]
        public DateTime LastUpdateTimestamp { get; set; }
        [JsonIgnore]
        public byte[] RecordVersion { get; set; }

        public virtual BusinessOrganizationDto MobileBusinessNavigation { get; set; }

        public virtual TaxItemTypeDto TaxItemTypeFkNavigation { get; set; }

        public virtual ICollection<MobileBusinessBusinessCategoryDto> MobileBusinessBusinessCategory { get; set; }

        public virtual PlatformMobileBusinessMonthlyVolumeBracketDto MonthlyVolumeBracketFkNavigation { get; set; }
        
        public virtual PersonDto OwnerFkNavigation { get; set; }

        public virtual PostOfficeAddressDto ReturnAddressFkNavigation { get; set; }

        public virtual PlatformScreensMainColorDto SelectedColorFkNavigation { get; set; }

        public virtual PlatformStoreThemeDto SelectedThemeFkNavigation { get; set; }

        public virtual ServiceAreaBracketDto ServiceAreaBracketFkNavigation { get; set; }
    }
}
