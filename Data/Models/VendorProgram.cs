using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VendorProgram
    {
        public VendorProgram()
        {
            VendorProgramContractTemplate = new HashSet<VendorProgramContractTemplate>();
            VendorProgramServiceProvider = new HashSet<VendorProgramServiceProvider>();
        }

        public long VendorProgramId { get; set; }
        public string ServiceCategory { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<VendorProgramContractTemplate> VendorProgramContractTemplate { get; set; }
        public virtual ICollection<VendorProgramServiceProvider> VendorProgramServiceProvider { get; set; }
    }
}
