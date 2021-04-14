using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessPlatformSupportedFormOfPayment
    {
        public long MobileBusinessPlatformSupportedFormOfPaymentId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long PlatformSupportedFormOfPaymentFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual PlatformSupportedFormOfPayment PlatformSupportedFormOfPaymentFkNavigation { get; set; }
    }
}
