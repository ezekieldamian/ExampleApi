using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductTerms
    {
        public long ProductTermsId { get; set; }
        public long ProductFk { get; set; }
        public string TermsText { get; set; }
        public int? TermDays { get; set; }
        public DateTime? PaymentFrequencyInDays { get; set; }
        public DateTime? LayAway { get; set; }
        public int? LoyaltyLevel { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
    }
}
