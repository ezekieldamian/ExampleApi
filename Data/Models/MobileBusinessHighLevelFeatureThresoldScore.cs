using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessHighLevelFeatureThresoldScore
    {
        public long MobileBusinessHighLevelFeatureThresoldScoreId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long GradedHighLevelFeatureFk { get; set; }
        public int? ThresholdScore { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual GradedHighLevelFeature GradedHighLevelFeatureFkNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
