using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class TrustedTradePromptProduct
    {
        public long TrustedTradePromptProductId { get; set; }
        public long TrustedTradePromptFk { get; set; }
        public long ProductFk { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
        public virtual TrustedTradePrompt TrustedTradePromptFkNavigation { get; set; }
    }
}
