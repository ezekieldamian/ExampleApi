using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class UniversalBadge
    {
        public UniversalBadge()
        {
            RetailCustomerBadge = new HashSet<RetailCustomerBadge>();
        }

        public long UniversalBadgeId { get; set; }
        public string BadgeTypeIndicator { get; set; }
        public int QualificationThreshold { get; set; }

        public virtual ICollection<RetailCustomerBadge> RetailCustomerBadge { get; set; }
    }
}
