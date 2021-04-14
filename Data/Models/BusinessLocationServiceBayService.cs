using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationServiceBayService
    {
        public long BusinessLocationServiceBayServiceId { get; set; }
        public long BusinessLocationServiceBayFk { get; set; }
        public long ProfessionalServiceFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocationServiceBay BusinessLocationServiceBayFkNavigation { get; set; }
        public virtual ProfessionalService ProfessionalServiceFkNavigation { get; set; }
    }
}
