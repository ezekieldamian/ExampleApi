using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PartyPreference
    {
        public long PartyPreferencesId { get; set; }
        public long PartyFk { get; set; }
        public string DoNotCallFlag { get; set; }
        public string DoNotContactFlag { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Party PartyFkNavigation { get; set; }
    }
}
