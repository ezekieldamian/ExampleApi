using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VendorProgramContractTemplate
    {
        public VendorProgramContractTemplate()
        {
            VendorProgramExecutedContract = new HashSet<VendorProgramExecutedContract>();
        }

        public long VendorProgramContractTemplateId { get; set; }
        public long? VendorProgramFk { get; set; }
        public string StandardContractName { get; set; }
        public string ContractVersionNumber { get; set; }
        public string ContractTemplate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual VendorProgram VendorProgramFkNavigation { get; set; }
        public virtual ICollection<VendorProgramExecutedContract> VendorProgramExecutedContract { get; set; }
    }
}
