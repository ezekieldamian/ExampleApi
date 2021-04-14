using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class SurveyResponse
    {
        public long CusotmerSurveyResponseId { get; set; }
        public long SurveyQuestionFk { get; set; }
        public long? SurvetQuestionPredefinedReponseFk { get; set; }
        public int? ScaledAnswer { get; set; }
        public string TextAnswer { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual SurveyQuestionPredefinedReponse SurvetQuestionPredefinedReponseFkNavigation { get; set; }
        public virtual SurveyQuestion SurveyQuestionFkNavigation { get; set; }
    }
}
