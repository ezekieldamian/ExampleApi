using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductRetailCategoryTag
    {
        public long ProductPropertyId { get; set; }
        public long ProductRetailCategoryFk { get; set; }
        public long TagFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ProductRetailCategory ProductRetailCategoryFkNavigation { get; set; }
        public virtual Tag TagFkNavigation { get; set; }
    }
}
