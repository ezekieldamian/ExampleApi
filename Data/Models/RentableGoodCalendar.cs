using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RentableGoodCalendar
    {
        public long ProductCalendarId { get; set; }
        public long? RentableGoodFk { get; set; }
        public long? RetailCustomerFk { get; set; }
        public long? MaintenanceVendorFk { get; set; }
        public DateTime? BeginUnavailabilityDate { get; set; }
        public DateTime? EndUnavailabilityDate { get; set; }
        public DateTime? PartialDayUseDate { get; set; }
        public DateTime? BeginPeriodOfUnavailability { get; set; }
        public DateTime? EndPeriodOfUnavailability { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ThirdPartyServiceProvider MaintenanceVendorFkNavigation { get; set; }
        public virtual RentableGood RentableGoodFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
