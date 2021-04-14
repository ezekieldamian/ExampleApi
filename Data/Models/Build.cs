using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Build
    {
        public long BuildNumber { get; set; }
        public string DbServicesRegressionTestStatus { get; set; }
        public DateTime LastUpdateTimeStamp { get; set; }
        public byte[] RecordVersion { get; set; }
    }
}
