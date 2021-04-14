using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class UniversalVirtueGrade
    {
        public UniversalVirtueGrade()
        {
            RetailCustomerVirtuePoints = new HashSet<RetailCustomerVirtuePoints>();
        }

        public long UniversalLoyaltyGradeId { get; set; }
        public long VirtueFk { get; set; }
        public string GradeName { get; set; }
        public int PointThreshold { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Virtue VirtueFkNavigation { get; set; }
        public virtual ICollection<RetailCustomerVirtuePoints> RetailCustomerVirtuePoints { get; set; }
    }
}
