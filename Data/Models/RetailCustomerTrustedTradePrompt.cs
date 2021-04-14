using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerTrustedTradePrompt
    {
        public long RetailCustomerTrustedTradePromptId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long TrustedTradePromptFk { get; set; }
        public DateTime? DropDatetime { get; set; }
        public DateTime? ViewDatetime { get; set; }
        public DateTime? ExpirationDatetime { get; set; }
        public int NumberOfTimesViewed { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
        public virtual TrustedTradePrompt TrustedTradePromptFkNavigation { get; set; }
    }
}
