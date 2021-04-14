using Empr.CoreServicesApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class PersonAsUserDto
    {
        public long PersonAsUserId { get; set; }
        public long? MobileBusinessFk { get; set; }
        public string PlatformPassword { get; set; }
        public long PlatformParticipantTypeFk { get; set; }
        public virtual ContactMechanism Contact { get; set; }

        public virtual Person Person { get; set; }
    }
}
