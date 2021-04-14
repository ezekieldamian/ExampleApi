using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO.Request
{
    public class BusinessPrioritiesRequestDto
    {
        public int MobileBusinessId { get; set; }

        public IEnumerable<BusinessPrioritiesDto> Priorities { get; set; }

    }
}
