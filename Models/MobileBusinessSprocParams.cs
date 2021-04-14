using System.Data;

namespace Empr.CoreServicesApi.Models
{
    public class MobileBusinessSprocParams
    {
        public string ActorType { get; set; }
        public int? UserId { get; set; } = 0;
        public int? ParentId { get; set; } = 0;
        public int? RecordId { get; set; } = 0;
        public string TransactionType { get; set; }
        public string Payload { get; set; }
    }
}