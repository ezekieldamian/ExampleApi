using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PartyPlatformObjectivePriority
    {
        public long PartyPlatformObjectivePriorityId { get; set; }
        public long PartyFk { get; set; }
        public long PlatformParticipantTypeFk { get; set; }
        public long PlatformObjectiveFk { get; set; }
        public int ObjectivePriority { get; set; }

        [JsonIgnore]
        public virtual Party PartyFkNavigation { get; set; }
        [JsonIgnore]
        public virtual PlatformObjective PlatformObjectiveFkNavigation { get; set; }
        [JsonIgnore]
        public virtual PlatformParticipantType PlatformParticipantTypeFkNavigation { get; set; }
    }
}
