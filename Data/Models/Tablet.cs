using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Tablet
    {
        public long TabletId { get; set; }

        public virtual Device TabletNavigation { get; set; }
    }
}
