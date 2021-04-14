using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO.Create
{
    public partial class MobileBusinessCreateDto
    {
        public string OwnerTitle { get; set; }
        public decimal? DefaultTradeRadiusInMiles { get; set; }
        public string OffersGoodsFlag { get; set; }
        public string OffersServicesFlag { get; set; }
        public string OffersAssetsFlag { get; set; }
        public string ShipsGoodsFlag { get; set; }
        public string AcceptsCreditCardFlag { get; set; }
        public string AcceptsAchFlag { get; set; }

        public string BusinessUrl { get; set; }

        public virtual BusinessOrganizationCreateDto MobileBusinessNavigation { get; set; }
        //public virtual TaxItemTypeCreateDto TaxItemTypeFkNavigation { get; set; }

    }
}
