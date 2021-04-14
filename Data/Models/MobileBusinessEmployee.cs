using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessEmployee
    {
        public MobileBusinessEmployee()
        {
            BusinessLocationManager = new HashSet<BusinessLocationManager>();
            BusinessLocationServiceBay = new HashSet<BusinessLocationServiceBay>();
            BusinessLocationStaff = new HashSet<BusinessLocationStaff>();
            Cart = new HashSet<Cart>();
            LiveChat = new HashSet<LiveChat>();
            MissedOrIncompleteWorkShift = new HashSet<MissedOrIncompleteWorkShift>();
            MobileBusinessEmployeeAuthorizationGroupMembership = new HashSet<MobileBusinessEmployeeAuthorizationGroupMembership>();
            MobileBusinessEmployeeBreakPreference = new HashSet<MobileBusinessEmployeeBreakPreference>();
            MobileBusinessEmployeeLocationFillin = new HashSet<MobileBusinessEmployeeLocationFillin>();
            MobileBusinessEmployeeServiceQualification = new HashSet<MobileBusinessEmployeeServiceQualification>();
            RestockEvent = new HashSet<RestockEvent>();
            RetailCustomerServicerPreference = new HashSet<RetailCustomerServicerPreference>();
        }

        public long MobileBusinessEmployeeId { get; set; }
        public long MobileBusinessFk { get; set; }
        public string IncomeStructureIndicator { get; set; }
        public string PictureUrl { get; set; }
        public string WorkScheduleIndicator { get; set; }
        public string SellingIndicator { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Person MobileBusinessEmployeeNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual MobileBusinessEmployeeAvailability MobileBusinessEmployeeAvailability { get; set; }
        public virtual MobileBusinessEmployeeConcreteSchedule MobileBusinessEmployeeConcreteSchedule { get; set; }
        public virtual MobileBusinessEmployeeScheduledWorkdayBreaks MobileBusinessEmployeeScheduledWorkdayBreaks { get; set; }
        public virtual ICollection<BusinessLocationManager> BusinessLocationManager { get; set; }
        public virtual ICollection<BusinessLocationServiceBay> BusinessLocationServiceBay { get; set; }
        public virtual ICollection<BusinessLocationStaff> BusinessLocationStaff { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<LiveChat> LiveChat { get; set; }
        public virtual ICollection<MissedOrIncompleteWorkShift> MissedOrIncompleteWorkShift { get; set; }
        public virtual ICollection<MobileBusinessEmployeeAuthorizationGroupMembership> MobileBusinessEmployeeAuthorizationGroupMembership { get; set; }
        public virtual ICollection<MobileBusinessEmployeeBreakPreference> MobileBusinessEmployeeBreakPreference { get; set; }
        public virtual ICollection<MobileBusinessEmployeeLocationFillin> MobileBusinessEmployeeLocationFillin { get; set; }
        public virtual ICollection<MobileBusinessEmployeeServiceQualification> MobileBusinessEmployeeServiceQualification { get; set; }
        public virtual ICollection<RestockEvent> RestockEvent { get; set; }
        public virtual ICollection<RetailCustomerServicerPreference> RetailCustomerServicerPreference { get; set; }
    }
}
