using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class TrustedTradePromptProductRetailCategory
    {
        public long TrustedTradePromptProductId { get; set; }
        public long TrustedTradePromptFk { get; set; }
        public long ProductRetailCategoryFk { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ProductRetailCategory ProductRetailCategoryFkNavigation { get; set; }
        public virtual TrustedTradePrompt TrustedTradePromptFkNavigation { get; set; }
    }
}
