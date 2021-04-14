namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileAddressAndServiceAreaDto
    {
        public long MobileBusinessId { get; set; }
        public long? ReturnAddressFK { get; set; }
        public long? MobileBusinessOrganizationFK { get; set; } 
        public long? TaxItemTypeFK { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string StatePostalCode { get; set; }
        public string ZipCode { get; set; }
        public string BusinessUrl { get; set; }
        public long? ServiceAreaBracketId { get; set; }
    }
}
