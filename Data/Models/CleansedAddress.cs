using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class CleansedAddress
    {
        public long CleansedAddressId { get; set; }
        public long PostOfficeAddressFk { get; set; }
        public string StreetNumber { get; set; }
        public string StreetPreDirection { get; set; }
        public string StreetName { get; set; }
        public string StreetPostDirection { get; set; }
        public string StreetType { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StatePostalCode { get; set; }
        public string ZipCode { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual PostOfficeAddress PostOfficeAddressFkNavigation { get; set; }
    }
}
