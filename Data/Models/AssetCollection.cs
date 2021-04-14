using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AssetCollection
    {
        public AssetCollection()
        {
            AssetCollectionAsset = new HashSet<AssetCollectionAsset>();
        }

        public long AssetCollectionId { get; set; }
        public string CollectionName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<AssetCollectionAsset> AssetCollectionAsset { get; set; }
    }
}
