using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformSupportedLanguage
    {
        public PlatformSupportedLanguage()
        {
            PartyLanguagePreference = new HashSet<PartyLanguagePreference>();
        }

        public long PlatformSupportedLanguageId { get; set; }
        public string LanguageCode { get; set; }
        public string TextName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<PartyLanguagePreference> PartyLanguagePreference { get; set; }
    }
}
