using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessCategory
    {
        public BusinessCategory()
        {
            DimensionSourceBusinessCategory = new HashSet<DimensionSourceBusinessCategory>();
            MobileBusinessBusinessCategory = new HashSet<MobileBusinessBusinessCategory>();
        }

        public long BusinessCategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal ServiceProviderTrustRatio { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        [JsonIgnore]
        public virtual ICollection<DimensionSourceBusinessCategory> DimensionSourceBusinessCategory { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusinessBusinessCategory> MobileBusinessBusinessCategory { get; set; }
    }
}
