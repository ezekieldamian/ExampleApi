namespace Empr.CoreServicesApi.Models.DTO
{
    public class GoodDto
    {
        public long GoodId { get; set; }
        public long? ManufacturerFk { get; set; }
        public long? ReturnAddressFk { get; set; }
        public int? QuantityOnHand { get; set; }
        public int QuantityAvailable { get; set; }
        public int WeightInPounds { get; set; }
        public int TargetQuantity { get; set; }
        public string PlatformGetsAllInventoryFlag { get; set; }
        public int? ReorderLagTimeInDays { get; set; }
        public string CustomizableFlag { get; set; }
        public int? ExpectedRestockDelayInDays { get; set; }
    }
}
