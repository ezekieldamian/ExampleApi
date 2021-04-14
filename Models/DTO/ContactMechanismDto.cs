namespace Empr.CoreServicesApi.Models.DTO
{
    public class ContactMechanismDto
    {
        public long ContactMechanismId { get; set; }
        public string Uuid { get; set; }

        public virtual EmailAddressDto EmailAddress { get; set; }
        public virtual PostOfficeAddressDto PostOfficeAddress { get; set; }
    }
}