using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MessageCategoryRoleBasedRecipient
    {
        public long MessageCategoryRoleBasedRecipientId { get; set; }
        public long PlatformMessageCategoryFk { get; set; }
        public long PlatformRoleFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual PlatformMessageCategory PlatformMessageCategoryFkNavigation { get; set; }
        public virtual PlatformRole PlatformRoleFkNavigation { get; set; }
    }
}
