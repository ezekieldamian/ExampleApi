using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RestockAlert
    {
        public long RestockAlertId { get; set; }
        public long RestockRequirementFk { get; set; }
        public long ContactMechanismFk { get; set; }
        public DateTime? AlertTimestamp { get; set; }
        public DateTime? ConfirmationFlag { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ContactMechanism ContactMechanismFkNavigation { get; set; }
        public virtual RestockRequirement RestockRequirementFkNavigation { get; set; }
    }
}
