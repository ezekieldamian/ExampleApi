using System;

namespace Empr.CoreServicesApi.Models.DTO.Update
{
    public class PartyUpdateDto
    {
        public string ApRelatedNotificationsSetting { get; set; }
        public string PurchaseAutoFillSetting { get; set; }
        public DateTime CreateDate { get; set; }
        public string Uuid { get; set; }
        public long TokenBalance { get; set; }
    }
}