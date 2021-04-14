using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO.Update
{
    public partial class MobileBusinessUpdateDto
    {
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
        public DateTime LastUpdateTimestamp { get; set; } = DateTime.UtcNow;

        public virtual BusinessOrganizationUpdateDto MobileBusinessNavigation { get; set; }

        public virtual ICollection<MobileBusinessBusinessCategoryDto> MobileBusinessBusinessCategory { get; set; }

    }
}
