using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformStoreTheme
    {
        public PlatformStoreTheme()
        {
            MobileBusiness = new HashSet<MobileBusiness>();
        }

        public long PlatformStoreThemeId { get; set; }
        public string TextDescription { get; set; }
        public byte[] ThemeImage { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<MobileBusiness> MobileBusiness { get; set; }
    }
}
