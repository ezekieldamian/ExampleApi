using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class UniversalItem
    {
        public UniversalItem()
        {
            ReverseAuctionItem = new HashSet<ReverseAuctionItem>();
            UniversalItemSource = new HashSet<UniversalItemSource>();
        }

        public long UniversalItemId { get; set; }
        public string ItemName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<ReverseAuctionItem> ReverseAuctionItem { get; set; }
        public virtual ICollection<UniversalItemSource> UniversalItemSource { get; set; }
    }
}
