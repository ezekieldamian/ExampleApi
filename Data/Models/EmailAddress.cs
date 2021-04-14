using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class EmailAddress
    {
        public long EmailAddressId { get; set; }
        public string EmailTypeCode { get; set; }
        public string Email { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ContactMechanism EmailAddressNavigation { get; set; }
    }
}
