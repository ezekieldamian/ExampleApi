using System;

namespace Empr.CoreServicesApi.Models.DTO.Update
{
    public class TaxItemTypeUpdateDto
    {
        public string TaxTypeName { get; set; }
        public DateTime LastUpdateTimestamp { get; set; } = DateTime.UtcNow;
    }
}