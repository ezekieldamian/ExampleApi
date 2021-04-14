using Empr.CoreServicesApi.Models.DTO;

namespace Empr.CoreServicesApi.Models
{
    public class ProductDto
    {
        public long ProductId { get; set; }
        public long MobileBusinessFk { get; set; }
        public string TextDescription { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal? MaximumPrice { get; set; }
        public string OkForPickupFlag { get; set; } = "N";
        public string OkForDeliveryFlag { get; set; } = "N";
        public string OkForShipFlag { get; set; } = "N";
        public virtual GoodDto Good { get; set; }
        public virtual ProfessionalServiceDto ProfessionalService { get; set; }
    }
}
