using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProfessionalService
    {
        public ProfessionalService()
        {
            BusinessLocationService = new HashSet<BusinessLocationService>();
            BusinessLocationServiceBayService = new HashSet<BusinessLocationServiceBayService>();
            MobileBusinessEmployeeServiceQualification = new HashSet<MobileBusinessEmployeeServiceQualification>();
            RetailCustomerServiceCalendarPreference = new HashSet<RetailCustomerServiceCalendarPreference>();
            RetailCustomerServiceLocationPreference = new HashSet<RetailCustomerServiceLocationPreference>();
            RetailCustomerServiceSpecialDuration = new HashSet<RetailCustomerServiceSpecialDuration>();
            RetailCustomerServicerPreference = new HashSet<RetailCustomerServicerPreference>();
        }

        public long ProfessionalServiceId { get; set; }
        public int? ExpectedDurationInMinutes { get; set; }
        public int? MeanFrequencyOfRecurranceInDays { get; set; }
        public string ServiceType { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProfessionalServiceNavigation { get; set; }
        public virtual ICollection<BusinessLocationService> BusinessLocationService { get; set; }
        public virtual ICollection<BusinessLocationServiceBayService> BusinessLocationServiceBayService { get; set; }
        public virtual ICollection<MobileBusinessEmployeeServiceQualification> MobileBusinessEmployeeServiceQualification { get; set; }
        public virtual ICollection<RetailCustomerServiceCalendarPreference> RetailCustomerServiceCalendarPreference { get; set; }
        public virtual ICollection<RetailCustomerServiceLocationPreference> RetailCustomerServiceLocationPreference { get; set; }
        public virtual ICollection<RetailCustomerServiceSpecialDuration> RetailCustomerServiceSpecialDuration { get; set; }
        public virtual ICollection<RetailCustomerServicerPreference> RetailCustomerServicerPreference { get; set; }
    }
}
