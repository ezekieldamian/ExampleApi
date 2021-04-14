using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PostOfficeAddress
    {
        public PostOfficeAddress()
        {
            BusinessLocation = new HashSet<BusinessLocation>();
            CartMeetupPlaceFkNavigation = new HashSet<Cart>();
            CartProductServiceDetail = new HashSet<CartProductServiceDetail>();
            CartShippingAddressFkNavigation = new HashSet<Cart>();
            CleansedAddress = new HashSet<CleansedAddress>();
            Good = new HashSet<Good>();
            MobileBusiness = new HashSet<MobileBusiness>();
            PartySavedCreditCard = new HashSet<PartySavedCreditCard>();
            ProductRetailCategory = new HashSet<ProductRetailCategory>();
            ProductSubscription = new HashSet<ProductSubscription>();
        }

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
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual ContactMechanism PostOfficeAddressNavigation { get; set; }
        public virtual ICollection<BusinessLocation> BusinessLocation { get; set; }
        public virtual ICollection<Cart> CartMeetupPlaceFkNavigation { get; set; }
        public virtual ICollection<CartProductServiceDetail> CartProductServiceDetail { get; set; }
        public virtual ICollection<Cart> CartShippingAddressFkNavigation { get; set; }
        public virtual ICollection<CleansedAddress> CleansedAddress { get; set; }
        public virtual ICollection<Good> Good { get; set; }
        public virtual ICollection<MobileBusiness> MobileBusiness { get; set; }
        public virtual ICollection<PartySavedCreditCard> PartySavedCreditCard { get; set; }
        public virtual ICollection<ProductRetailCategory> ProductRetailCategory { get; set; }
        public virtual ICollection<ProductSubscription> ProductSubscription { get; set; }
    }
}
