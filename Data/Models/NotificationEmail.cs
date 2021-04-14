using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class NotificationEmail
    {
        public long NotificationEmailId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long RetailCustomerFk { get; set; }
        public string SourceEmail { get; set; }
        public string DestinationEmail { get; set; }
        public DateTime SendTimestamp { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
