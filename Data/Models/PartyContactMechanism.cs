using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PartyContactMechanism
    {
        public long PartyContactMechanismId { get; set; }
        public long PartyFk { get; set; }
        public long ContactMechanismFk { get; set; }
        public long? ContactRoleFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ContactMechanism ContactMechanismFkNavigation { get; set; }
        public virtual Party PartyFkNavigation { get; set; }
    }
}
