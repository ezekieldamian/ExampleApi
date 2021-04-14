using Empr.CoreServicesApi.Data.Models;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class PartyDto
    {
        public long PartyId { get; set; }
        public string ApRelatedNotificationsSetting { get; set; }
        public string PurchaseAutoFillSetting { get; set; }
        public DateTime CreateDate { get; set; }
        public string Uuid { get; set; }
        public long TokenBalance { get; set; }

        public virtual BusinessOrganizationDto BusinessOrganization { get; set; }
        public virtual ICollection<PartyBankAccountDto> PartyBankAccount { get; set; }
    }
}