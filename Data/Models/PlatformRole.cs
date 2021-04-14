using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformRole
    {
        public PlatformRole()
        {
            MessageCategoryRoleBasedRecipient = new HashSet<MessageCategoryRoleBasedRecipient>();
            MobileBusinessEmployeeAuthorizationGroupRole = new HashSet<MobileBusinessEmployeeAuthorizationGroupRole>();
            RoleOperationalFunction = new HashSet<RoleOperationalFunction>();
        }

        public long PlatformRoleId { get; set; }
        public string RoleDescription { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<MessageCategoryRoleBasedRecipient> MessageCategoryRoleBasedRecipient { get; set; }
        public virtual ICollection<MobileBusinessEmployeeAuthorizationGroupRole> MobileBusinessEmployeeAuthorizationGroupRole { get; set; }
        public virtual ICollection<RoleOperationalFunction> RoleOperationalFunction { get; set; }
    }
}
