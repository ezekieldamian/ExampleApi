using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Virtue
    {
        public Virtue()
        {
            CartPointsAwarded = new HashSet<CartPointsAwarded>();
            MobileBusinessVirtueRanking = new HashSet<MobileBusinessVirtueRanking>();
            MobileBusinessVirtueScore = new HashSet<MobileBusinessVirtueScore>();
            ProductVirtuePointCredit = new HashSet<ProductVirtuePointCredit>();
            RetailCustomerVirtuePoints = new HashSet<RetailCustomerVirtuePoints>();
            UniversalVirtueGrade = new HashSet<UniversalVirtueGrade>();
        }

        public long VirtueId { get; set; }
        public string TextName { get; set; }
        public int? PlatformEmployeeRanking { get; set; }
        public decimal? PlatformEmployeeWeight { get; set; }
        public int? PlatformMobileBusinessRanking { get; set; }
        public decimal? PlatformMobileBusinessWeight { get; set; }
        public int? PlatformRetailCustomerRanking { get; set; }
        public decimal? PlatformRetailCustomerWeight { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<CartPointsAwarded> CartPointsAwarded { get; set; }
        public virtual ICollection<MobileBusinessVirtueRanking> MobileBusinessVirtueRanking { get; set; }
        public virtual ICollection<MobileBusinessVirtueScore> MobileBusinessVirtueScore { get; set; }
        public virtual ICollection<ProductVirtuePointCredit> ProductVirtuePointCredit { get; set; }
        public virtual ICollection<RetailCustomerVirtuePoints> RetailCustomerVirtuePoints { get; set; }
        public virtual ICollection<UniversalVirtueGrade> UniversalVirtueGrade { get; set; }
    }
}
