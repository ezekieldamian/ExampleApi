using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Auction
    {
        public Auction()
        {
            AuctionInvitedMobileBusiness = new HashSet<AuctionInvitedMobileBusiness>();
            AuctionItem = new HashSet<AuctionItem>();
        }

        public long AuctionId { get; set; }
        public long? MobileBusinessFk { get; set; }
        public string PlatformSponsorFlag { get; set; }
        public string AuctionName { get; set; }
        public DateTime ScheduledStartTimestamp { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual ICollection<AuctionInvitedMobileBusiness> AuctionInvitedMobileBusiness { get; set; }
        public virtual ICollection<AuctionItem> AuctionItem { get; set; }
    }
}
