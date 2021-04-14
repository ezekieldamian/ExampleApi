using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessOrganization
    {
        public long BusinessOrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string Ein { get; set; }
        public string Dba { get; set; }
        public string NonProfitFlag { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Party BusinessOrganizationNavigation { get; set; }
        [JsonIgnore]
        public virtual Charity Charity { get; set; }
        [JsonIgnore]
        public virtual MobileBusiness MobileBusiness { get; set; }
        [JsonIgnore]
        public virtual MobileBusinessAggregator MobileBusinessAggregator { get; set; }
        [JsonIgnore]
        public virtual ThirdPartyServiceProvider ThirdPartyServiceProvider { get; set; }
    }
}
