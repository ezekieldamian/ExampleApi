using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Charity
    {
        public Charity()
        {
            MobileBusinessCharity = new HashSet<MobileBusinessCharity>();
            RetailCustomerCurrentCarharitiesAvailable = new HashSet<RetailCustomerCurrentCarharitiesAvailable>();
        }

        public long CharityId { get; set; }
        public string TradeName { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public decimal InceptionToDateReceipts { get; set; }
        public DateTime StartDate { get; set; }
        public string GraphicIcon { get; set; }
        public decimal SpecifiedPlatformMatchRatio { get; set; }
        public decimal? PlatformMatchMaxPortionOfCartTotal { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessOrganization CharityNavigation { get; set; }
        public virtual ICollection<MobileBusinessCharity> MobileBusinessCharity { get; set; }
        public virtual ICollection<RetailCustomerCurrentCarharitiesAvailable> RetailCustomerCurrentCarharitiesAvailable { get; set; }
    }
}
