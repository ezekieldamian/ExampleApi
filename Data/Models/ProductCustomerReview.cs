using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ProductCustomerReview
    {
        public long ProductCustomerReviewId { get; set; }
        public long ProductFk { get; set; }
        public long RetailCustomerFk { get; set; }
        public DateTime ReviewTimestamp { get; set; }
        public string Rating { get; set; }
        public string TextMessage { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product ProductFkNavigation { get; set; }
        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
