using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessServiceOperatingParameters
    {
        public long MobileBusinessFk { get; set; }
        public long MobileBusinessServiceOperatingParametersId { get; set; }
        public int? ServiceLocationType { get; set; }
        public string SchedulingType { get; set; }
        public int BusinessLocationBasedServiceMilesDisplacement { get; set; }
        public int BusinessLocationBasedServiceTimeFutureDisplacementInDays { get; set; }
        public int BusinessLocationBasesServiceTimePastDisplacementInDays { get; set; }
        public int? ServiceDeliveryType { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
