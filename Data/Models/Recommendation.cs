using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Recommendation
    {
        public long RecommendationId { get; set; }
        public long PersonFk { get; set; }
        public long? ProductCategoryFk { get; set; }
        public long? ProductFk { get; set; }
        public string Pitch { get; set; }
        public string Video { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Person PersonFkNavigation { get; set; }
        public virtual ProductRetailCategory ProductCategoryFkNavigation { get; set; }
        public virtual Product ProductFkNavigation { get; set; }
    }
}
