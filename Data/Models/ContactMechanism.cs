using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ContactMechanism
    {
        public ContactMechanism()
        {
            BusinessLocationContactMechanism = new HashSet<BusinessLocationContactMechanism>();
            PartyContactMechanism = new HashSet<PartyContactMechanism>();
            Person = new HashSet<Person>();
            RestockAlert = new HashSet<RestockAlert>();
        }

        public long ContactMechanismId { get; set; }
        public string Uuid { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Device Device { get; set; }
        public virtual EmailAddress EmailAddress { get; set; }
        public virtual PostOfficeAddress PostOfficeAddress { get; set; }
        public virtual ICollection<BusinessLocationContactMechanism> BusinessLocationContactMechanism { get; set; }
        public virtual ICollection<PartyContactMechanism> PartyContactMechanism { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<RestockAlert> RestockAlert { get; set; }
    }
}
