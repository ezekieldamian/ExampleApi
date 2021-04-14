using Newtonsoft.Json;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class PlatformMobileBusinessMonthlyVolumeBracketDto
    {
        public long PlatformMobileBusinessMonthlyVolumeBracketId { get; set; }
        [JsonIgnore]
        public decimal MinimumVolumeThreshold { get; set; }
        [JsonIgnore]
        public decimal MaximumVolumeThreshold { get; set; }
        public string UpperLimitDescription => MaximumVolumeThreshold > 999999 ? $"more than ${$"{MinimumVolumeThreshold:n0}"}" : $"up to ${$"{MaximumVolumeThreshold:n0}"}";

        [JsonIgnore]
        public string Description => $"${(int)MinimumVolumeThreshold}-${(int)MaximumVolumeThreshold}";
    }
}