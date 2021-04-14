using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RetailCustomerPushCommunication
    {
        public long RetailCustomerPushCommunicationId { get; set; }
        public long RetailCustomerFk { get; set; }
        public string CommunicationContent { get; set; }
        public DateTime LsastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual RetailCustomer RetailCustomerFkNavigation { get; set; }
    }
}
