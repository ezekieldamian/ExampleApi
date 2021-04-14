using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VwServiceSlots
    {
        public long MobileBusinessEmployeeId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public long ProfessionalServiceId { get; set; }
        public string TextDescription { get; set; }
        public int? TimeSlotIndex { get; set; }
        public int? AppointmentStartTime { get; set; }
        public int? AppointmentEndTime { get; set; }
    }
}
