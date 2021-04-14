using Empr.CoreServicesApi.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models.DTO
{
    public class PostOfficeAddressDto
    {
        public long PostOfficeAddressId { get; set; }
        public string AddressType { get; set; }
        public string AddrressSource { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string StatePostalCode { get; set; }
        public string ZipCode { get; set; }
        public string CountryCd { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public DateTime? VerifiedDt { get; set; }


        public virtual ContactMechanismDto PostOfficeAddressNavigation { get; set; }
        
        public virtual ICollection<BusinessLocationDto> BusinessLocation { get; set; }

        [JsonIgnore]
        public virtual ICollection<Cart> Cart { get; set; }
        [JsonIgnore]
        public virtual ICollection<CleansedAddress> CleansedAddress { get; set; }
        [JsonIgnore]
        public virtual ICollection<Good> Good { get; set; }
        [JsonIgnore]
        public virtual ICollection<MobileBusiness> MobileBusiness { get; set; }
        [JsonIgnore]
        public virtual ICollection<PartySavedCreditCard> PartySavedCreditCard { get; set; }
        [JsonIgnore]
        public virtual ICollection<ProductRetailCategory> ProductRetailCategory { get; set; }
        [JsonIgnore]
        public virtual ICollection<ProductSubscription> ProductSubscription { get; set; }
    }
}