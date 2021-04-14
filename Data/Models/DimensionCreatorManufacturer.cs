using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class DimensionCreatorManufacturer
    {
        public long DimensionCreatorManufacturerId { get; set; }
        public long DimensionFk { get; set; }
        public long ManufacturerFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Dimension DimensionFkNavigation { get; set; }
        public virtual ThirdPartyServiceProvider ManufacturerFkNavigation { get; set; }
    }
}
