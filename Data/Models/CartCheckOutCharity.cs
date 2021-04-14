using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CartCheckOutCharity
    {
        public long CartCheckOutCharityId { get; set; }
        public long CartFk { get; set; }
        public long CharityFk { get; set; }
        public decimal? SpecifiedRatioOfCartTotal { get; set; }
        public decimal? AmountOfCharitibleContribution { get; set; }
        public decimal? PlatformMatchAmount { get; set; }
        public decimal? MobileBusinessMatchAmount { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual Charity CharityFkNavigation { get; set; }
    }
}
