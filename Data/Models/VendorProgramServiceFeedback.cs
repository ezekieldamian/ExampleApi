using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VendorProgramServiceFeedback
    {
        public long VendorProgramServiceFeedbackId { get; set; }
        public long VendorProgramExecutedContractFk { get; set; }
        public string Rating { get; set; }
        public string TextFeedback { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual VendorProgramExecutedContract VendorProgramExecutedContractFkNavigation { get; set; }
    }
}
