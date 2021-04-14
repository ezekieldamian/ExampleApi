namespace Empr.CoreServicesApi.Models.DTO
{
    public class StateOrProvinceDto
    {
        public long StateOrProvinceId { get; set; }
        public long CountryFk { get; set; }
        public string StateOrProvinceName { get; set; }
        public string PostalAbbreviation { get; set; }
    }
}