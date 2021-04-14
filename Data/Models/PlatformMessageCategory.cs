using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformMessageCategory
    {
        public PlatformMessageCategory()
        {
            MessageCategoryRoleBasedRecipient = new HashSet<MessageCategoryRoleBasedRecipient>();
            PlatformMessage = new HashSet<PlatformMessage>();
        }

        public long PlatformMessageCategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<MessageCategoryRoleBasedRecipient> MessageCategoryRoleBasedRecipient { get; set; }
        public virtual ICollection<PlatformMessage> PlatformMessage { get; set; }
    }
}
