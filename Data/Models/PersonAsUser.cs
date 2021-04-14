using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PersonAsUser
    {
        public long PersonAsUserId { get; set; }
        public long PersonFk { get; set; }
        public long PlatformParticipantTypeFk { get; set; }
        public long? MobileBusinessFk { get; set; }
        public long? DeviceFk { get; set; }
        public string Uuid { get; set; }
        public string PersonStatus { get; set; }
        public byte[] PasswordBin { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        [JsonIgnore]
        public virtual Device DeviceFkNavigation { get; set; }
        [JsonIgnore]
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        [JsonIgnore]
        public virtual Person PersonFkNavigation { get; set; }
        [JsonIgnore]
        public virtual PlatformParticipantType PlatformParticipantTypeFkNavigation { get; set; }
    }
}
