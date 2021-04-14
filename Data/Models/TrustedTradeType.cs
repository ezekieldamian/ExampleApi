using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class TrustedTradeType
    {
        public TrustedTradeType()
        {
            TrustedTradePrompt = new HashSet<TrustedTradePrompt>();
        }

        public long TrustedTradeTypeId { get; set; }
        public string TextName { get; set; }
        public string TextDescription { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<TrustedTradePrompt> TrustedTradePrompt { get; set; }
    }
}
