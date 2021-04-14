using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO.Update
{
    public class PartyBankAccountUpdateDto
    {
        public string Ein { get; set; }
        public PartyBankAccountUpdateBankAccountDto PartyBankAccount { get; set; }

        public virtual ICollection<MobileBusinessPlatformSupportedFormOfPaymentDto> MobileBusinessPlatformSupportedFormOfPayment { get; set; }
    }
}