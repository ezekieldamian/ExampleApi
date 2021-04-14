using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RoleOperationalFunction
    {
        public long RoleOperationalFunctionId { get; set; }
        public long PlatformRoleFk { get; set; }
        public long PlatformOperationalFunctionFk { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual PlatformOperationalFunction PlatformOperationalFunctionFkNavigation { get; set; }
        public virtual PlatformRole PlatformRoleFkNavigation { get; set; }
    }
}
