using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CartProductServiceDetail
    {
        public long CartProductServiceDetailId { get; set; }
        public long CartProductFk { get; set; }
        public long? CartTrustedTradePromptFk { get; set; }
        public long? BusinessLocationFk { get; set; }
        public long? ServiceAddressFk { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int AppointmentStartTime { get; set; }
        public int? ExpectedDurationInMinutes { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual CartProduct CartProductFkNavigation { get; set; }
        public virtual CartTrustedTradePrompt CartTrustedTradePromptFkNavigation { get; set; }
        public virtual PostOfficeAddress ServiceAddressFkNavigation { get; set; }
    }
}
