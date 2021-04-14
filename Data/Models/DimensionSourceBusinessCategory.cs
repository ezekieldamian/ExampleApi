using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class DimensionSourceBusinessCategory
    {
        public long DimensionSourceBusinessCategoryId { get; set; }
        public long BusinessCategoryFk { get; set; }
        public long DimensionFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessCategory BusinessCategoryFkNavigation { get; set; }
        public virtual Dimension DimensionFkNavigation { get; set; }
    }
}
