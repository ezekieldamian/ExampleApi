using Newtonsoft.Json;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class BusinessOrganizationDto
    {
        public long BusinessOrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string Ein { get; set; }
        public string Dba { get; set; }
        public string NonProfitFlag { get; set; }

        [JsonIgnore]
        public virtual PartyDto BusinessOrganizationNavigation { get; set; }
    }
}