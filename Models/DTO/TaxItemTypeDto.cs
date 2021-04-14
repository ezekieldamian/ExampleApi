using Newtonsoft.Json;
using System;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class TaxItemTypeDto
    {
        public long TaxItemTypeId { get; set; }
        public string TaxTypeName { get; set; }
        [JsonIgnore]
        public DateTime LastUpdateTimestamp { get; set; }
    }
}