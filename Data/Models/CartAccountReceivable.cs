using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CartAccountReceivable
    {
        public long CartAccountReceivableId { get; set; }
        public long CartFk { get; set; }
        public long? TermNumberOfPayments { get; set; }
        public DateTime TermBeginTimePeriod { get; set; }
        public decimal GeneralPaymentAmount { get; set; }
        public decimal FinalPaymentAmount { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
    }
}
