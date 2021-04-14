using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Shipment
    {
        public long ShipmentId { get; set; }
        public long CartFk { get; set; }
        public string ShipmentTypeCd { get; set; }
        public string ShipmentStatus { get; set; }
        public string DeliveryId { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Cart CartFkNavigation { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
