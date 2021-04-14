using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class LiveChatMessage
    {
        public long LiveChatMessageId { get; set; }
        public long LiveChatFk { get; set; }
        public DateTime TalkTimestamp { get; set; }
        public string TalkerType { get; set; }
        public string InstantMessage { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual LiveChat LiveChatFkNavigation { get; set; }
    }
}
