using Empr.CoreServicesApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Models.DTO
{
    public partial class EmailAddressDto
    {   
        public long EmailAddressId { get; set; }
        public string EmailTypeCode { get; set; }
        public string Email { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ContactMechanismDto EmailAddressNavigation { get; set; }
    }
}
