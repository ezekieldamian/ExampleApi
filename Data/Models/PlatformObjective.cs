using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformObjective
    {
        public PlatformObjective()
        {
            PartyPlatformObjectivePriority = new HashSet<PartyPlatformObjectivePriority>();
        }

        public long PlatformObjectiveId { get; set; }
        public long PlatformParticipantTypeFk { get; set; }
        public string BusinessObjectiveCode { get; set; }
        public string BusinessObjectiveDescription { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual PlatformParticipantType PlatformParticipantTypeFkNavigation { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartyPlatformObjectivePriority> PartyPlatformObjectivePriority { get; set; }
    }
}
