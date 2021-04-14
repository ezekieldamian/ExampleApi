using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformPersonToPersonFollow
    {
        public long PlatformPersonToPersonFollowId { get; set; }
        public long InfluencerFk { get; set; }
        public long FollowerFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Person FollowerFkNavigation { get; set; }
        public virtual Party InfluencerFkNavigation { get; set; }
    }
}
