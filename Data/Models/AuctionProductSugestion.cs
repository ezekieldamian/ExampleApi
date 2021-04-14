using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AuctionProductSugestion
    {
        public long AuctionProductSugestionId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long ProductFk { get; set; }
        public int SuggestedQuantity { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual Product ProductFkNavigation { get; set; }
        public virtual AuctionInvitedMobileBusiness AuctionInvitedMobileBusiness { get; set; }
    }
}
