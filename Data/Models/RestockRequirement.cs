using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RestockRequirement
    {
        public RestockRequirement()
        {
            RestockAlert = new HashSet<RestockAlert>();
        }

        public long RestockRequirementId { get; set; }
        public long ProductFk { get; set; }
        public int DetectionTs { get; set; }
        public int QuantityAvailable { get; set; }
        public int TargetQuantity { get; set; }
        public DateTime? ResolutionNotificationTransmissionTimestamp { get; set; }
        public DateTime? ResolutionNotificationConfirmationFlag { get; set; }
        public DateTime? ResolutionTimestamp { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
        public virtual ICollection<RestockAlert> RestockAlert { get; set; }
    }
}
