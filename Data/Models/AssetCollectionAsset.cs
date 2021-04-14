using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AssetCollectionAsset
    {
        public long AssetCollectioniAsset { get; set; }
        public long AssetCollectionFk { get; set; }
        public long AssetFk { get; set; }
        public DateTime LastUpdateTimeStamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual AssetCollection AssetCollectionFkNavigation { get; set; }
        public virtual Asset AssetFkNavigation { get; set; }
    }
}
