using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VendorProgramExecutedContract
    {
        public long VendorProgramExecutedContractId { get; set; }
        public long VendorProgramContractTemplateFk { get; set; }
        public long VendorProgramServiceProviderFk { get; set; }
        public long? VendorProgramServiceRecipientFk { get; set; }
        public DateTime ContractExecutionDate { get; set; }
        public string ExecutedContract { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual VendorProgramContractTemplate VendorProgramContractTemplateFkNavigation { get; set; }
        public virtual VendorProgramServiceProvider VendorProgramServiceProviderFkNavigation { get; set; }
        public virtual MobileBusiness VendorProgramServiceRecipientFkNavigation { get; set; }
        public virtual VendorProgramServiceFeedback VendorProgramServiceFeedback { get; set; }
    }
}
