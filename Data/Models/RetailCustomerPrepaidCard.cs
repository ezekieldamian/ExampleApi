using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerPrepaidCard
    {
        public int RetailCusotmerCustomerPrepaidCardId { get; set; }
        public long RetailCustomerFk { get; set; }
        public long MobileBusinessFk { get; set; }
        public string CardNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public int? RechargeTriggerAmount { get; set; }
        public decimal? RechargeTransferAmount { get; set; }
        public decimal? MonthlyMadMoneyAutomaticTransferAmount { get; set; }
        public DateTime? DayOfMonthForAutomaticTransfer { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
