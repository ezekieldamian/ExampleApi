using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PaymentApplication
    {
        public long PaymentApplicationId { get; set; }
        public long InvoiceFk { get; set; }
        public long PaymentFk { get; set; }
        public decimal? PaymentApplicationAmount { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Invoice InvoiceFkNavigation { get; set; }
        public virtual Payment PaymentFkNavigation { get; set; }
    }
}
