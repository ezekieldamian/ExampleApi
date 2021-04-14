using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessRecruitmentMessage
    {
        public long MobileBusinessRecruitmentMessageId { get; set; }
        public long MobileBuinessFk { get; set; }
        public string MobileBusinessEmployeeRecruitementMessage { get; set; }
        public string RetailCustomerRecruitementMessagew { get; set; }

        public virtual MobileBusiness MobileBuinessFkNavigation { get; set; }
    }
}
