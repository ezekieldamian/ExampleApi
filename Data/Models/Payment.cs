using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Payment
    {
        public Payment()
        {
            PaymentApplication = new HashSet<PaymentApplication>();
        }

        public long PaymentId { get; set; }
        public long PartyFk { get; set; }
        public DateTime RemittanceDate { get; set; }
        public DateTime? SettlementDate { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Party PartyFkNavigation { get; set; }
        public virtual ICollection<PaymentApplication> PaymentApplication { get; set; }
    }
}
