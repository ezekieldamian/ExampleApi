using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            PaymentApplication = new HashSet<PaymentApplication>();
        }

        public long InvoiceId { get; set; }
        public long? ShipmentFk { get; set; }
        public decimal InvoiceAmount { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Shipment ShipmentFkNavigation { get; set; }
        public virtual ICollection<PaymentApplication> PaymentApplication { get; set; }
    }
}
