using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class UniversalItemSource
    {
        public long UniversalItemSourceId { get; set; }
        public long UniversalItemFk { get; set; }
        public long ProductFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
        public virtual UniversalItem UniversalItemFkNavigation { get; set; }
    }
}
