using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerVirtuePoints
    {
        public long RetailCustomerVirtuePointsId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long MobileBusinessFk { get; set; }
        public long VirtueFk { get; set; }
        public long? UniversalVirtueGradeFk { get; set; }
        public int CurrentPointBalance { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
        public virtual UniversalVirtueGrade UniversalVirtueGradeFkNavigation { get; set; }
        public virtual Virtue VirtueFkNavigation { get; set; }
    }
}
