using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class TrustedTradePrompt
    {
        public TrustedTradePrompt()
        {
            CartTrustedTradePrompt = new HashSet<CartTrustedTradePrompt>();
            RetailCustomerTrustedTradePrompt = new HashSet<RetailCustomerTrustedTradePrompt>();
            TrustedTradePromptProduct = new HashSet<TrustedTradePromptProduct>();
            TrustedTradePromptProductRetailCategory = new HashSet<TrustedTradePromptProductRetailCategory>();
        }

        public long TrustedTradePromptId { get; set; }
        public long TrustedTradeTypeFk { get; set; }
        public int WeightingFactor { get; set; }
        public string AdCopy { get; set; }
        public decimal? Price { get; set; }
        public string GoodsOrServicesIndicator { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime UpdateTimestamp { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual TrustedTradeType TrustedTradeTypeFkNavigation { get; set; }
        public virtual ICollection<CartTrustedTradePrompt> CartTrustedTradePrompt { get; set; }
        public virtual ICollection<RetailCustomerTrustedTradePrompt> RetailCustomerTrustedTradePrompt { get; set; }
        public virtual ICollection<TrustedTradePromptProduct> TrustedTradePromptProduct { get; set; }
        public virtual ICollection<TrustedTradePromptProductRetailCategory> TrustedTradePromptProductRetailCategory { get; set; }
    }
}
