using Empr.CoreServicesApi.Data.Models;
using Newtonsoft.Json;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class PlatformObjectiveDto
    {
        public long PlatformObjectiveId { get; set; }
        public long PlatformParticipantTypeFk { get; set; }
        public string BusinessObjectiveCode { get; set; }
        public string BusinessObjectiveDescription { get; set; }

        [JsonIgnore]
        public virtual PlatformParticipantTypeDto PlatformParticipantTypeFkNavigation { get; set; }

    }
}