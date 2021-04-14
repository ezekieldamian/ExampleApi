using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AssetClass
    {
        public AssetClass()
        {
            Asset = new HashSet<Asset>();
            InverseParentAssetClassFkNavigation = new HashSet<AssetClass>();
        }

        public long AssetClassId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long ParentAssetClassFk { get; set; }
        public long? AssetDealStructureFk { get; set; }
        public string ClassName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual AssetDealStructure AssetDealStructureFkNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual AssetClass ParentAssetClassFkNavigation { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<AssetClass> InverseParentAssetClassFkNavigation { get; set; }
    }
}
