using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AuditTrailMaster
    {
        public long AuditTrailMasterId { get; set; }
        public string OdsTableName { get; set; }
        public long SurrogateId { get; set; }
        public long? PartyFk { get; set; }
        public string Action { get; set; }
        public DateTime ActionTimestamp { get; set; }

        public virtual Party PartyFkNavigation { get; set; }
    }
}
