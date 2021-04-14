using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Device
    {
        public Device()
        {
            PersonAsUser = new HashSet<PersonAsUser>();
        }

        public long DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string Model { get; set; }
        public string ModelNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Os { get; set; }
        public string OsVersion { get; set; }
        public string SerialNumber { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ContactMechanism DeviceNavigation { get; set; }
        public virtual Smartphone Smartphone { get; set; }
        public virtual ICollection<PersonAsUser> PersonAsUser { get; set; }
    }
}
