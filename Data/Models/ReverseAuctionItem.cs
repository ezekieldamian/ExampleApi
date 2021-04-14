using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ReverseAuctionItem
    {
        public long ReverseAuctionItemId { get; set; }
        public long ReverseAuctionFk { get; set; }
        public long UniversalItemFk { get; set; }
        public long? WinningBidderFk { get; set; }
        public int? LotNumber { get; set; }
        public DateTime AuctionOpenTimestamp { get; set; }
        public DateTime? AuctionCloseTimestamp { get; set; }
        public decimal? WinningBid { get; set; }
        public decimal? QuantityRequested { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal MaximumPricePer { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ReverseAuction ReverseAuctionFkNavigation { get; set; }
        public virtual UniversalItem UniversalItemFkNavigation { get; set; }
        public virtual MobileBusiness WinningBidderFkNavigation { get; set; }
    }
}
