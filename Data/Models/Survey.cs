using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Survey
    {
        public Survey()
        {
            SurveyQuestion = new HashSet<SurveyQuestion>();
        }

        public long SurveyId { get; set; }
        public string SurveyName { get; set; }
        public long? SponsorFk { get; set; }
        public string TargetIndicator { get; set; }
        public string AppliesByDefaultFlag { get; set; }
        public string SurveyTrigger { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ICollection<SurveyQuestion> SurveyQuestion { get; set; }
    }
}
