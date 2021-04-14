using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Asset
    {
        public Asset()
        {
            AssetCollectionAsset = new HashSet<AssetCollectionAsset>();
        }

        public long AssetId { get; set; }
        public long? AssetClassFk { get; set; }
        public long AssetDealStructureFk { get; set; }
        public string AssetName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual AssetClass AssetClassFkNavigation { get; set; }
        public virtual AssetDealStructure AssetDealStructureFkNavigation { get; set; }
        public virtual Product AssetNavigation { get; set; }
        public virtual ICollection<AssetCollectionAsset> AssetCollectionAsset { get; set; }
    }
}
