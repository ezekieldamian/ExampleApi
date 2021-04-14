using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VwMobileBusiness
    {
        public long MobileBusinessId { get; set; }
        public string OrganizationName { get; set; }
        public string OwnerTitle { get; set; }
        public string OffersGoodsFlag { get; set; }
        public string OffersServicesFlag { get; set; }
        public string OffersAssetsFlag { get; set; }
        public string ShipsGoodsFlag { get; set; }
        public string AcceptsCreditCardFlag { get; set; }
        public string AcceptsAchFlag { get; set; }
        public long? MonthlyVolumeBracketFk { get; set; }
        public long? SelectedThemeFk { get; set; }
        public long? SelectedColorFk { get; set; }
        public string HeadquartersAddressLine1 { get; set; }
        public string HeadquartersAddressLine2 { get; set; }
        public string HeadquartersAddressLine3 { get; set; }
        public string HeadquartersCity { get; set; }
        public string HeadquartersStatePostalCode { get; set; }
        public string HeadquartersZipCode { get; set; }
    }
}
