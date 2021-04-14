using Empr.CoreServicesApi.Models.DTO.Update;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO
{
    public partial class MobileBusinessUpdateSalesReponseDto
    {
        public long MobileBusinessId { get; set; }
        public long? MonthlyVolumeBracketFk { get; set; }

        public virtual PlatformMobileBusinessMonthlyVolumeBracketDto MonthlyVolumeBracketFkNavigation { get; set; }

    }
}
