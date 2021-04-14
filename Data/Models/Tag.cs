using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Tag
    {
        public Tag()
        {
            ProductRetailCategoryTag = new HashSet<ProductRetailCategoryTag>();
            ProductTag = new HashSet<ProductTag>();
        }

        public long TagId { get; set; }
        public string TagText { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<ProductRetailCategoryTag> ProductRetailCategoryTag { get; set; }
        public virtual ICollection<ProductTag> ProductTag { get; set; }
    }
}
