using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO.Request
{
    public class AddProductsRequestDto
    {
        public long MobileBusinessId { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
