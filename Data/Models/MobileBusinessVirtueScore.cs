using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessVirtueScore
    {
        public long MobileBusinessVirtueScoreId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long VirtueFk { get; set; }
        public decimal Score { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual Virtue VirtueFkNavigation { get; set; }
    }
}
