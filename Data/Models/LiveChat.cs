using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class LiveChat
    {
        public LiveChat()
        {
            LiveChatMessage = new HashSet<LiveChatMessage>();
        }

        public long LiveChatId { get; set; }
        public long? PlatformEmployeeFk { get; set; }
        public long? MobileBusinessEmployeeFk { get; set; }
        public long? RetailCustomerFk { get; set; }
        public DateTime FirstMessageTimestamp { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
        public virtual PlatformEmployee PlatformEmployeeFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
        public virtual ICollection<LiveChatMessage> LiveChatMessage { get; set; }
    }
}
