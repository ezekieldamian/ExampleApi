using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AuctionInvitedMobileBusiness
    {
        public long AuctionInvitedMobileBusinessId { get; set; }
        public long AuctionFk { get; set; }
        public long MobileBusinessFk { get; set; }
        public DateTime InvationDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Auction AuctionFkNavigation { get; set; }
        public virtual AuctionProductSugestion AuctionInvitedMobileBusinessNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
    }
}
