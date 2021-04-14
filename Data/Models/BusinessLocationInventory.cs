using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationInventory
    {
        public BusinessLocationInventory()
        {
            BusinessLocationInventoryDimensionValue = new HashSet<BusinessLocationInventoryDimensionValue>();
        }

        public long BusinessLocationInventoryId { get; set; }
        public long BusinessLocationFk { get; set; }
        public long GoodFk { get; set; }
        public string DefinitionCompleteFlag { get; set; }
        public string ChildDimensionValues { get; set; }
        public int? InventoryLevel { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual Good GoodFkNavigation { get; set; }
        public virtual ICollection<BusinessLocationInventoryDimensionValue> BusinessLocationInventoryDimensionValue { get; set; }
    }
}
