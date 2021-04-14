using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VwMobileBusinessEmpoloyee
    {
        public long MobileBusinessEmployeeId { get; set; }
        public string FullName { get; set; }
        public long MobileBusinessId { get; set; }
        public string IncomeStructureIndicator { get; set; }
    }
}
