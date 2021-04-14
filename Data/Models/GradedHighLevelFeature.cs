using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class GradedHighLevelFeature
    {
        public long GradedHighLevelFeatureId { get; set; }
        public string GradedHighLevelFeatureName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessHighLevelFeatureThresoldScore MobileBusinessHighLevelFeatureThresoldScore { get; set; }
    }
}
