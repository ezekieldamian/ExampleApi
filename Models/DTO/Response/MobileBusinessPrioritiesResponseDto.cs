using Empr.CoreServicesApi.Data.Models;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO.Response
{
    public partial class MobileBusinessRioritiesResponseDto
    {
        public long MobileBusinessId { get; set; }

        public IEnumerable<PartyPlatformObjectivePriorityDto> Priorities { get; set; }
    }
}
