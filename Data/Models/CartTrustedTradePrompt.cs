using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CartTrustedTradePrompt
    {
        public CartTrustedTradePrompt()
        {
            CartProductServiceDetail = new HashSet<CartProductServiceDetail>();
        }

        public long CartTrustedTradePromptId { get; set; }
        public long CartFk { get; set; }
        public long TrustedTradePromptFk { get; set; }
        public int? Price { get; set; }
        public int OrderQuantity { get; set; }
        public decimal? TotalDiscount { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual TrustedTradePrompt TrustedTradePromptFkNavigation { get; set; }
        public virtual ICollection<CartProductServiceDetail> CartProductServiceDetail { get; set; }
    }
}
