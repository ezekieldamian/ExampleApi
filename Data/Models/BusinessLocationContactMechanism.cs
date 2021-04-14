using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationContactMechanism
    {
        public long BusinessLocationContactMechanismId { get; set; }
        public long BusinessLocationFk { get; set; }
        public long ContactMechanismFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual ContactMechanism ContactMechanismFkNavigation { get; set; }
    }
}
