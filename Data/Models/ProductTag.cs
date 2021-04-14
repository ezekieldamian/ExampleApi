using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductTag
    {
        public long ProductPropertyId { get; set; }
        public long ProductFk { get; set; }
        public long TagFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
        public virtual Tag TagFkNavigation { get; set; }
    }
}
