using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocationService
    {
        public long BusinessLocationServiceId { get; set; }
        public long BusinessLocationFk { get; set; }
        public long ProfessionalServiceFk { get; set; }
        public int? ServiceCapacity { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual ProfessionalService ProfessionalServiceFkNavigation { get; set; }
    }
}
