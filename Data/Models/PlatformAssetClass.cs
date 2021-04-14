using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformAssetClass
    {
        public long PlatformAssetClassId { get; set; }
        public string ClassName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }
    }
}
