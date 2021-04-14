using System;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class BusinessLocationDto
    {
        public long BusinessLocationId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long? AddressFk { get; set; }
        public string LocationName { get; set; }
        public string HeadquartersFlag { get; set; }
        public int GreenwichOffset { get; set; }
        public decimal? TradeRadiusInMiles { get; set; }
        public DateTime LocationStartDate { get; set; }
        public DateTime? LocationEndDate { get; set; }
        public string RetailWarehouseIndicator { get; set; }
        public int? ServiceCapacity { get; set; }
        public string ServiceCapacityTreatmentIndicator { get; set; }
    }
}