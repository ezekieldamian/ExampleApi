using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PartySavedCreditCard
    {
        public PartySavedCreditCard()
        {
            CartPayment = new HashSet<CartPayment>();
        }

        public long PartySavedCreditCardId { get; set; }
        public long? PartyFk { get; set; }
        public long? BillingAddressFk { get; set; }
        public string CreditCardNumber { get; set; }
        public string SecurityCode { get; set; }
        public string ExpirationDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }
        public string ZipCode { get; set; }

        public virtual PostOfficeAddress BillingAddressFkNavigation { get; set; }
        public virtual Party PartyFkNavigation { get; set; }
        public virtual ICollection<CartPayment> CartPayment { get; set; }
    }
}
