using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationServiceBay
    {
        public BusinessLocationServiceBay()
        {
            BusinessLocationServiceBayCalendar = new HashSet<BusinessLocationServiceBayCalendar>();
            BusinessLocationServiceBayService = new HashSet<BusinessLocationServiceBayService>();
        }

        public long BusinessLocationServiceBayId { get; set; }
        public long BusinessLocationFk { get; set; }
        public long? AssignedEmployeeFk { get; set; }
        public string ServiceBayLabel { get; set; }
        public int? Capacity { get; set; }
        public string StartDt { get; set; }
        public string EndDt { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployee AssignedEmployeeFkNavigation { get; set; }
        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual ICollection<BusinessLocationServiceBayCalendar> BusinessLocationServiceBayCalendar { get; set; }
        public virtual ICollection<BusinessLocationServiceBayService> BusinessLocationServiceBayService { get; set; }
    }
}
