using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformEmployee
    {
        public PlatformEmployee()
        {
            LiveChat = new HashSet<LiveChat>();
        }

        public long PlatformEmployeeId { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Person PlatformEmployeeNavigation { get; set; }
        public virtual ICollection<LiveChat> LiveChat { get; set; }
    }
}
