using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class WeeklySchedule
    {
        public WeeklySchedule()
        {
            BusinessLocationHoursOfOperation = new HashSet<BusinessLocationHoursOfOperation>();
            MobileBusinessEmployeeAvailability = new HashSet<MobileBusinessEmployeeAvailability>();
            MobileBusinessEmployeeConcreteSchedule = new HashSet<MobileBusinessEmployeeConcreteSchedule>();
            MobileBusinessEmployeeLocationFillin = new HashSet<MobileBusinessEmployeeLocationFillin>();
            MobileBusinessEmployeeScheduledWorkdayBreaks = new HashSet<MobileBusinessEmployeeScheduledWorkdayBreaks>();
            MobileBusinessHoursOfOperation = new HashSet<MobileBusinessHoursOfOperation>();
        }

        public long WeeklyScheduleId { get; set; }
        public int? SundayBegin { get; set; }
        public int? SundayEnd { get; set; }
        public int? MondayBegin { get; set; }
        public int? MondayEnd { get; set; }
        public int? TuesdayBegin { get; set; }
        public int? TuesdayEnd { get; set; }
        public int? WednesdayEnd { get; set; }
        public int? WednesdayBegin { get; set; }
        public int? ThursdayBegin { get; set; }
        public int? ThursdayEnd { get; set; }
        public int? FridayBegin { get; set; }
        public int? FridayEnd { get; set; }
        public int? SaturdayBegin { get; set; }
        public int? SaturdayEnd { get; set; }
        public string Uuid { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<BusinessLocationHoursOfOperation> BusinessLocationHoursOfOperation { get; set; }
        public virtual ICollection<MobileBusinessEmployeeAvailability> MobileBusinessEmployeeAvailability { get; set; }
        public virtual ICollection<MobileBusinessEmployeeConcreteSchedule> MobileBusinessEmployeeConcreteSchedule { get; set; }
        public virtual ICollection<MobileBusinessEmployeeLocationFillin> MobileBusinessEmployeeLocationFillin { get; set; }
        public virtual ICollection<MobileBusinessEmployeeScheduledWorkdayBreaks> MobileBusinessEmployeeScheduledWorkdayBreaks { get; set; }
        public virtual ICollection<MobileBusinessHoursOfOperation> MobileBusinessHoursOfOperation { get; set; }
    }
}
