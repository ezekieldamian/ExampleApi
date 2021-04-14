using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformScreensMainColor
    {
        public PlatformScreensMainColor()
        {
            MobileBusiness = new HashSet<MobileBusiness>();
        }

        public long PlatformScreensMainColorId { get; set; }
        public byte[] ColorImage { get; set; }
        public string HexidecimalCode { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        [JsonIgnore]
        public virtual ICollection<MobileBusiness> MobileBusiness { get; set; }
    }
}
