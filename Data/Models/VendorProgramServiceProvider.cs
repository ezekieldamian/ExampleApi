using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VendorProgramServiceProvider
    {
        public VendorProgramServiceProvider()
        {
            VendorProgramExecutedContract = new HashSet<VendorProgramExecutedContract>();
        }

        public long VendorProgramServiceProviderId { get; set; }
        public long VendorProgramFk { get; set; }
        public long OrganizationFk { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal AverageRating { get; set; }
        public decimal Reputation { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual VendorProgram VendorProgramFkNavigation { get; set; }
        public virtual ICollection<VendorProgramExecutedContract> VendorProgramExecutedContract { get; set; }
    }
}
