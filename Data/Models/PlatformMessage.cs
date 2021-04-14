using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformMessage
    {
        public long PlatformMessageId { get; set; }
        public long MessageCategoryFk { get; set; }
        public long MessageRecipientFk { get; set; }
        public long? SourceSubSystem { get; set; }
        public DateTime SendTimestamp { get; set; }
        public string TextMessage { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual PlatformMessageCategory MessageCategoryFkNavigation { get; set; }
        public virtual Party MessageRecipientFkNavigation { get; set; }
    }
}
