using Empr.CoreServicesApi.Data.Models;
using Newtonsoft.Json;

namespace Empr.CoreServicesApi.Models.DTO
{
    public partial class PartyPlatformObjectivePriorityDto
    {
        public long PartyPlatformObjectivePriorityId { get; set; }
        public long PartyFk { get; set; }
        public long PlatformParticipantTypeFk { get; set; }
        public long PlatformObjectiveFk { get; set; }
        public int ObjectivePriority { get; set; }
    }
}
