using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ReverseAuction
    {
        public ReverseAuction()
        {
            ReverseAuctionItem = new HashSet<ReverseAuctionItem>();
        }

        public long ReverseAuctionId { get; set; }
        public string AuctionName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<ReverseAuctionItem> ReverseAuctionItem { get; set; }
    }
}
