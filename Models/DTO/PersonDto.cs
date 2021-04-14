using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class PersonDto
    {
        public long PersonId { get; set; }
        public long? PrimaryContactMechanismFk { get; set; }
        public string PlatformUserName { get; set; }
        public string FullName { get; set; }
        public string PlatformSmartphoneNumber { get; set; }

        public virtual PartyDto PersonNavigation { get; set; }

        public virtual ContactMechanismDto PrimaryContactMechanismFkNavigation { get; set; }

        public virtual EmailAddressDto EmailAddressNavigation { get; set; }
        public virtual ICollection<PersonAsUserDto> PersonAsUser { get; set; }


    }
}