using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Smartphone
    {
        public long SmartphoneId { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Device SmartphoneNavigation { get; set; }
    }
}
