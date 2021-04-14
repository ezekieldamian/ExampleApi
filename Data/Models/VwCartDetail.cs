using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VwCartDetail
    {
        public long CartId { get; set; }
        public long MobileBusinessId { get; set; }
        public long RetailCusotmerId { get; set; }
        public DateTime StartTimestamp { get; set; }
        public long? TrustedTradePromptId { get; set; }
        public decimal? Price { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
    }
}
