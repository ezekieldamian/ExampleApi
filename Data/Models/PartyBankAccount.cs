using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PartyBankAccount
    {
        public PartyBankAccount()
        {
            CartPayment = new HashSet<CartPayment>();
        }

        public long PartyBankAccountId { get; set; }
        public long PartyFk { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Party PartyFkNavigation { get; set; }
        public virtual ICollection<CartPayment> CartPayment { get; set; }
    }
}
