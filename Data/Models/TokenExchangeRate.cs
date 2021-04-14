using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class TokenExchangeRate
    {
        public long TokenExchangeRateId { get; set; }
        public string OutsideCurrencyCode { get; set; }
        public decimal? TokenBid { get; set; }
        public decimal? TokenAsk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }
    }
}
