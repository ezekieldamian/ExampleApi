using Newtonsoft.Json;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class GetNumberOfCustomersBracketDto
    {
        public long PlatformMobileBusinessNumberOfCustomersBracketId { get; set; }
        [JsonIgnore]
        public int NumberOfCustomersLowerLimit { get; set; }
        [JsonIgnore]
        public int NumberOfCustomersUpperLimit { get; set; }
        public string UpperLimitDescription => NumberOfCustomersUpperLimit > 999999 ? $"more than {$"{NumberOfCustomersLowerLimit:n0}"}" : $"up to {$"{NumberOfCustomersUpperLimit:n0}"}";
        [JsonIgnore]
        public string Description => $"{NumberOfCustomersLowerLimit}-{NumberOfCustomersUpperLimit}";
    }
}