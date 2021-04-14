using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Party
    {
        public Party()
        {
            AuditTrailMaster = new HashSet<AuditTrailMaster>();
            PartyBankAccount = new HashSet<PartyBankAccount>();
            PartyContactMechanism = new HashSet<PartyContactMechanism>();
            PartyImage = new HashSet<PartyImage>();
            PartyLanguagePreference = new HashSet<PartyLanguagePreference>();
            PartyPlatformObjectivePriority = new HashSet<PartyPlatformObjectivePriority>();
            PartySavedCreditCard = new HashSet<PartySavedCreditCard>();
            Payment = new HashSet<Payment>();
            PlatformMessage = new HashSet<PlatformMessage>();
            PlatformPersonToPersonFollow = new HashSet<PlatformPersonToPersonFollow>();
        }

        public long PartyId { get; set; }
        public string ApRelatedNotificationsSetting { get; set; }
        public string PurchaseAutoFillSetting { get; set; }
        public DateTime CreateDate { get; set; }
        public string Uuid { get; set; }
        public long TokenBalance { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        [JsonIgnore]
        public virtual BusinessOrganization BusinessOrganization { get; set; }
        [JsonIgnore]
        public virtual PartyPreference PartyPreference { get; set; }
        [JsonIgnore]
        public virtual Person Person { get; set; }
        [JsonIgnore]
        public virtual ICollection<AuditTrailMaster> AuditTrailMaster { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartyBankAccount> PartyBankAccount { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartyContactMechanism> PartyContactMechanism { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartyImage> PartyImage { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartyLanguagePreference> PartyLanguagePreference { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartyPlatformObjectivePriority> PartyPlatformObjectivePriority { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartySavedCreditCard> PartySavedCreditCard { get; set; }
        [JsonIgnore]
        public virtual ICollection<Payment> Payment { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlatformMessage> PlatformMessage { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlatformPersonToPersonFollow> PlatformPersonToPersonFollow { get; set; }
    }
}
