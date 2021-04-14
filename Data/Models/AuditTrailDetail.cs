using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class AuditTrailDetail
    {
        public long AuditTrailMasterFk { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual AuditTrailMaster AuditTrailMasterFkNavigation { get; set; }
    }
}
