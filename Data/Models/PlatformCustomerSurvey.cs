using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PlatformCustomerSurvey
    {
        public long PlatformCustomerSurveyId { get; set; }
        public string SurveyName { get; set; }
        public string AppliesByDefaultFlag { get; set; }
        public string SurveyTrigger { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }
    }
}
