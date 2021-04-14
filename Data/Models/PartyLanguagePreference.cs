using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PartyLanguagePreference
    {
        public long PartyLanguagePreferenceId { get; set; }
        public long PartyFk { get; set; }
        public long PlatformSupportedLanguageFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Party PartyFkNavigation { get; set; }
        public virtual PlatformSupportedLanguage PlatformSupportedLanguageFkNavigation { get; set; }
    }
}
