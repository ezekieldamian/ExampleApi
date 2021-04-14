using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartAccountReceivable = new HashSet<CartAccountReceivable>();
            CartPayment = new HashSet<CartPayment>();
            CartPointsAwarded = new HashSet<CartPointsAwarded>();
            CartProduct = new HashSet<CartProduct>();
            CartTrustedTradePrompt = new HashSet<CartTrustedTradePrompt>();
            ProductSubscription = new HashSet<ProductSubscription>();
            Shipment = new HashSet<Shipment>();
        }

        public long CartId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long BusinessLocationFk { get; set; }
        public long RetailCustomerFk { get; set; }
        public long? MobileBusinessEmployeeFk { get; set; }
        public long? ShippingAddressFk { get; set; }
        public long? MeetupPlaceFk { get; set; }
        public DateTime? MeetupTime { get; set; }
        public string PurchaseModeIndicator { get; set; }
        public string CartStatusIndicator { get; set; }
        public DateTime StartTimestamp { get; set; }
        public string SpecifiedShippingMethod { get; set; }
        public decimal MerchandiseTotal { get; set; }
        public decimal FreightCharge { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalAmountDue { get; set; }
        public decimal CharitibleContribution { get; set; }
        public decimal PlatformCharityMatch { get; set; }
        public decimal MobileBusinessCharityMatch { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessLocation BusinessLocationFkNavigation { get; set; }
        public virtual PostOfficeAddress MeetupPlaceFkNavigation { get; set; }
        public virtual MobileBusinessEmployee MobileBusinessEmployeeFkNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
        public virtual PostOfficeAddress ShippingAddressFkNavigation { get; set; }
        public virtual ICollection<CartAccountReceivable> CartAccountReceivable { get; set; }
        public virtual ICollection<CartPayment> CartPayment { get; set; }
        public virtual ICollection<CartPointsAwarded> CartPointsAwarded { get; set; }
        public virtual ICollection<CartProduct> CartProduct { get; set; }
        public virtual ICollection<CartTrustedTradePrompt> CartTrustedTradePrompt { get; set; }
        public virtual ICollection<ProductSubscription> ProductSubscription { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
    }
}
