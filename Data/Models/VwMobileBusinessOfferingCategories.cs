using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VwMobileBusinessOfferingCategories
    {
        public long MobileBusinessId { get; set; }
        public string OrganizationName { get; set; }
        public string OfferMode { get; set; }
        public long BusinessCategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
