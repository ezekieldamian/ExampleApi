using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BidHistory
    {
        public long BidHistoryId { get; set; }
        public long AuctionItemFk { get; set; }
        public long RetailCustomerFk { get; set; }
        public decimal? BidAmount { get; set; }
        public DateTime BidEventTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual AuctionItem AuctionItemFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
