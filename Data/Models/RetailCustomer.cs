using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomer
    {
        public RetailCustomer()
        {
            AuctionItem = new HashSet<AuctionItem>();
            BidHistory = new HashSet<BidHistory>();
            BusinessLocationServiceBayCalendar = new HashSet<BusinessLocationServiceBayCalendar>();
            Cart = new HashSet<Cart>();
            LiveChat = new HashSet<LiveChat>();
            NotificationEmail = new HashSet<NotificationEmail>();
            ProductCustomerReview = new HashSet<ProductCustomerReview>();
            RentableGoodCalendar = new HashSet<RentableGoodCalendar>();
            RetailCustomerBadge = new HashSet<RetailCustomerBadge>();
            RetailCustomerBusinessRelationship = new HashSet<RetailCustomerBusinessRelationship>();
            RetailCustomerCurrentCarharitiesAvailable = new HashSet<RetailCustomerCurrentCarharitiesAvailable>();
            RetailCustomerMobileBusinessAffinity = new HashSet<RetailCustomerMobileBusinessAffinity>();
            RetailCustomerPushCommunication = new HashSet<RetailCustomerPushCommunication>();
            RetailCustomerServiceCalendarPreference = new HashSet<RetailCustomerServiceCalendarPreference>();
            RetailCustomerServiceLocationPreference = new HashSet<RetailCustomerServiceLocationPreference>();
            RetailCustomerServiceSpecialDuration = new HashSet<RetailCustomerServiceSpecialDuration>();
            RetailCustomerServicerPreference = new HashSet<RetailCustomerServicerPreference>();
            RetailCustomerTrustedTradePrompt = new HashSet<RetailCustomerTrustedTradePrompt>();
            RetailCustomerVirtuePoints = new HashSet<RetailCustomerVirtuePoints>();
            Wishlist = new HashSet<Wishlist>();
        }

        public long RetailCustomerId { get; set; }
        public long? DefaultFormOfPaymentFk { get; set; }
        public int? ReputationScore { get; set; }
        public string UseTokensDefault { get; set; }
        public string UseTermsWhenAvailable { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual PlatformSupportedFormOfPayment DefaultFormOfPaymentFkNavigation { get; set; }
        public virtual Person RetailCustomerNavigation { get; set; }
        public virtual RetailCustomerPrepaidCard RetailCustomerPrepaidCard { get; set; }
        public virtual ICollection<AuctionItem> AuctionItem { get; set; }
        public virtual ICollection<BidHistory> BidHistory { get; set; }
        public virtual ICollection<BusinessLocationServiceBayCalendar> BusinessLocationServiceBayCalendar { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<LiveChat> LiveChat { get; set; }
        public virtual ICollection<NotificationEmail> NotificationEmail { get; set; }
        public virtual ICollection<ProductCustomerReview> ProductCustomerReview { get; set; }
        public virtual ICollection<RentableGoodCalendar> RentableGoodCalendar { get; set; }
        public virtual ICollection<RetailCustomerBadge> RetailCustomerBadge { get; set; }
        public virtual ICollection<RetailCustomerBusinessRelationship> RetailCustomerBusinessRelationship { get; set; }
        public virtual ICollection<RetailCustomerCurrentCarharitiesAvailable> RetailCustomerCurrentCarharitiesAvailable { get; set; }
        public virtual ICollection<RetailCustomerMobileBusinessAffinity> RetailCustomerMobileBusinessAffinity { get; set; }
        public virtual ICollection<RetailCustomerPushCommunication> RetailCustomerPushCommunication { get; set; }
        public virtual ICollection<RetailCustomerServiceCalendarPreference> RetailCustomerServiceCalendarPreference { get; set; }
        public virtual ICollection<RetailCustomerServiceLocationPreference> RetailCustomerServiceLocationPreference { get; set; }
        public virtual ICollection<RetailCustomerServiceSpecialDuration> RetailCustomerServiceSpecialDuration { get; set; }
        public virtual ICollection<RetailCustomerServicerPreference> RetailCustomerServicerPreference { get; set; }
        public virtual ICollection<RetailCustomerTrustedTradePrompt> RetailCustomerTrustedTradePrompt { get; set; }
        public virtual ICollection<RetailCustomerVirtuePoints> RetailCustomerVirtuePoints { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
