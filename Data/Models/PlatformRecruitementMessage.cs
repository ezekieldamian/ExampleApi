using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformRecruitementMessage
    {
        public long PlatformRecruitementMessageId { get; set; }
        public string MobileBusinessEmployeeRecruitementMessage { get; set; }
        public string RetailCustomerRecruitementMessage { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }
    }
}
