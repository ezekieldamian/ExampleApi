using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CartPayment
    {
        public long CartParmentId { get; set; }
        public long CartFk { get; set; }
        public long? PartySavedCreditCardFk { get; set; }
        public long? PartyBankAccountFk { get; set; }
        public string TemporaryCreditCardNumber { get; set; }
        public string TemporaryExpirationDate { get; set; }
        public string TemporarySecurityCode { get; set; }
        public string TemporaryZipCode { get; set; }
        public string PaidFromPrepaidCardFlag { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual PartyBankAccount PartyBankAccountFkNavigation { get; set; }
        public virtual PartySavedCreditCard PartySavedCreditCardFkNavigation { get; set; }
    }
}
