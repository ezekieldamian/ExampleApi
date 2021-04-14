using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AuctionItem
    {
        public AuctionItem()
        {
            BidHistory = new HashSet<BidHistory>();
        }

        public long AuctionItemId { get; set; }
        public long AuctionFk { get; set; }
        public long ProductFk { get; set; }
        public long? WinningBidderFk { get; set; }
        public int LotNumber { get; set; }
        public decimal? MinimumPrice { get; set; }
        public DateTime? AuctionOpenTimestamp { get; set; }
        public DateTime? AuctionCloseTimestamp { get; set; }
        public decimal? WinningBid { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Auction AuctionFkNavigation { get; set; }
        public virtual Product ProductFkNavigation { get; set; }
        public virtual RetailCustomer WinningBidderFkNavigation { get; set; }
        public virtual ICollection<BidHistory> BidHistory { get; set; }
    }
}
