using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessKeyword
    {
        public long MobileBusinessKeywordId { get; set; }
        public long MobileBusinessFk { get; set; }
        public string Keyword { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
