using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformError
    {
        public long PlatformErrorId { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorContext { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }
    }
}
