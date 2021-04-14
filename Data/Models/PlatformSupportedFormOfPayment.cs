using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformSupportedFormOfPayment
    {
        public PlatformSupportedFormOfPayment()
        {
            MobileBusinessPlatformSupportedFormOfPayment = new HashSet<MobileBusinessPlatformSupportedFormOfPayment>();
            RetailCustomer = new HashSet<RetailCustomer>();
        }

        public long PlatormSupportedFormOfPaymentId { get; set; }
        public string TextDescription { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<MobileBusinessPlatformSupportedFormOfPayment> MobileBusinessPlatformSupportedFormOfPayment { get; set; }
        public virtual ICollection<RetailCustomer> RetailCustomer { get; set; }
    }
}
