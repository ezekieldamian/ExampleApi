using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class SurveyQuestion
    {
        public SurveyQuestion()
        {
            SurveyQuestionPredefinedReponse = new HashSet<SurveyQuestionPredefinedReponse>();
        }

        public long SurveyQuestionId { get; set; }
        public long SurveyFk { get; set; }
        public string TextOfQuestion { get; set; }
        public string ResponseTypeIndicator { get; set; }
        public int? ScaleMinimum { get; set; }
        public int? ScaleMaximum { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Survey SurveyFkNavigation { get; set; }
        public virtual SurveyResponse SurveyResponse { get; set; }
        public virtual ICollection<SurveyQuestionPredefinedReponse> SurveyQuestionPredefinedReponse { get; set; }
    }
}
