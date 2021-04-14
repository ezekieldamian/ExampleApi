using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductVirtuePointCredit
    {
        public long ProductVirtuePointCreditId { get; set; }
        public long ProductFk { get; set; }
        public long VirtueFk { get; set; }
        public int PointsToAward { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
        public virtual Virtue VirtueFkNavigation { get; set; }
    }
}
