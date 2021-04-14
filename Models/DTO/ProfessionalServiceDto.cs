namespace Empr.CoreServicesApi.Models.DTO
{
    public class ProfessionalServiceDto
    {

        public long ProfessionalServiceId { get; set; }
        public int? ExpectedDurationInMinutes { get; set; }
        public int? MeanFrequencyOfRecurranceInDays { get; set; }
        public string ServiceType { get; set; } = "N";
    }
}
