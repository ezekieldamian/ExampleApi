using System;

namespace Empr.CoreServicesApi.Models.DTO.Update
{
    public class BusinessCategoryDto
    {
        public long BusinessCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string TextDescription { get; set; }
        public decimal ServiceProviderTrustRatio { get; set; }
        public string NaicsCode { get; set; }
        public string OkForGoodsFlag { get; set; }
        public string OkForServicesFlag { get; set; }
        public string OkForAssetsFlag { get; set; }
    }
}