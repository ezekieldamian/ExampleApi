using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Person
    {
        public Person()
        {
            MobileBusiness = new HashSet<MobileBusiness>();
            PersonAsUser = new HashSet<PersonAsUser>();
            PlatformPersonToPersonFollow = new HashSet<PlatformPersonToPersonFollow>();
            Recommendation = new HashSet<Recommendation>();
        }

        public long PersonId { get; set; }
        public long? HouseholdSegmentFk { get; set; }
        public long? SubSegmentFk { get; set; }
        public long? PrimaryContactMechanismFk { get; set; }
        public string PlatformUserName { get; set; }
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }
        public string PlatformSmartphoneNumber { get; set; }

        public virtual Party PersonNavigation { get; set; }
        public virtual ContactMechanism PrimaryContactMechanismFkNavigation { get; set; }
        public virtual MobileBusinessEmployee MobileBusinessEmployee { get; set; }
        public virtual PlatformEmployee PlatformEmployee { get; set; }
        public virtual Prospect Prospect { get; set; }
        public virtual RetailCustomer RetailCustomer { get; set; }
        public virtual ICollection<MobileBusiness> MobileBusiness { get; set; }
        public virtual ICollection<PersonAsUser> PersonAsUser { get; set; }
        public virtual ICollection<PlatformPersonToPersonFollow> PlatformPersonToPersonFollow { get; set; }
        public virtual ICollection<Recommendation> Recommendation { get; set; }
        public string RefreshToken { get; internal set; }
    }
}
