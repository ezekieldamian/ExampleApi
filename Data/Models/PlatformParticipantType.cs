using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformParticipantType
    {
        public PlatformParticipantType()
        {
            PartyImage = new HashSet<PartyImage>();
            PartyPlatformObjectivePriority = new HashSet<PartyPlatformObjectivePriority>();
            PersonAsUser = new HashSet<PersonAsUser>();
            PlatformObjective = new HashSet<PlatformObjective>();
        }

        public long PlatformParticipantTypeId { get; set; }
        public string ParticipantTypeIndicator { get; set; }
        public string TextDescription { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        [JsonIgnore]
        public virtual ICollection<PartyImage> PartyImage { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartyPlatformObjectivePriority> PartyPlatformObjectivePriority { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonAsUser> PersonAsUser { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlatformObjective> PlatformObjective { get; set; }
    }
}
