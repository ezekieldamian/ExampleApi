using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class TaxItemType
    {
        public TaxItemType()
        {
            MobileBusiness = new HashSet<MobileBusiness>();
            Product = new HashSet<Product>();
            ProductRetailCategory = new HashSet<ProductRetailCategory>();
        }

        public long TaxItemTypeId { get; set; }
        public string TaxTypeName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        [JsonIgnore]
        public virtual ICollection<MobileBusiness> MobileBusiness { get; set; }
        [JsonIgnore]
        public virtual ICollection<Product> Product { get; set; }
        [JsonIgnore]
        public virtual ICollection<ProductRetailCategory> ProductRetailCategory { get; set; }
    }
}
