using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformOperationalFunction
    {
        public PlatformOperationalFunction()
        {
            RoleOperationalFunction = new HashSet<RoleOperationalFunction>();
        }

        public long PlatformOperationalFunctionId { get; set; }
        public string FunctionName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<RoleOperationalFunction> RoleOperationalFunction { get; set; }
    }
}
