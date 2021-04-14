using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationServiceBayCalendar
    {
        public long BusinessLocationServiceBayCalendarId { get; set; }
        public long BusinessLocationServiceBayFk { get; set; }
        public long RetailCustomerFk { get; set; }
        public DateTime AppointmentSetupTimestamp { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int AppointmentTime { get; set; }
        public DateTime AppointmentStartTimestamp { get; set; }
        public int? ScheduledDurationOfServiceInMinutes { get; set; }
        public string AppointmentStatus { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocationServiceBay BusinessLocationServiceBayFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
