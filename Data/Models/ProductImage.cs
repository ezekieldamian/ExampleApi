using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductImage
    {
        public long ProductImageId { get; set; }
        public long ProductFk { get; set; }
        public byte[] RetailImage { get; set; }
        public string ImageVettedIndicator { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
    }
}
