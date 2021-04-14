using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class SurveyQuestionPredefinedReponse
    {
        public SurveyQuestionPredefinedReponse()
        {
            SurveyResponse = new HashSet<SurveyResponse>();
        }

        public long SurveyQuestionPredefinedReponseId { get; set; }
        public long SurveyQuestionFk { get; set; }
        public string AnswerChoiceText { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual SurveyQuestion SurveyQuestionFkNavigation { get; set; }
        public virtual ICollection<SurveyResponse> SurveyResponse { get; set; }
    }
}
