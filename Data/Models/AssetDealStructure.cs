using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AssetDealStructure
    {
        public long AssetDealStructureId { get; set; }
        public string TextDescription { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual AssetClass AssetClass { get; set; }
    }
}
