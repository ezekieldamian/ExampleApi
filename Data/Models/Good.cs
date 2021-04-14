using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Good
    {
        public Good()
        {
            BusinessLocationInventory = new HashSet<BusinessLocationInventory>();
        }

        public long GoodId { get; set; }
        public long? ManufacturerFk { get; set; }
        public long? ReturnAddressFk { get; set; }
        public int? QuantityOnHand { get; set; }
        public int QuantityAvailable { get; set; }
        public int WeightInPounds { get; set; }
        public int TargetQuantity { get; set; }
        public string PlatformGetsAllInventoryFlag { get; set; }
        public int? ReorderLagTimeInDays { get; set; }
        public string CustomizableFlag { get; set; }
        public int? ExpectedRestockDelayInDays { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Product GoodNavigation { get; set; }
        public virtual ThirdPartyServiceProvider ManufacturerFkNavigation { get; set; }
        public virtual PostOfficeAddress ReturnAddressFkNavigation { get; set; }
        public virtual RentableGood RentableGood { get; set; }
        public virtual ICollection<BusinessLocationInventory> BusinessLocationInventory { get; set; }
    }
}
