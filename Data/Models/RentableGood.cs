using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class RentableGood
    {
        public RentableGood()
        {
            RentableGoodCalendar = new HashSet<RentableGoodCalendar>();
        }

        public long RentableGoodId { get; set; }
        public long? RentableLocationFk { get; set; }
        public long? RentableSubLocationFk { get; set; }
        public string SerialNumber { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual Good RentableGoodNavigation { get; set; }
        public virtual ICollection<RentableGoodCalendar> RentableGoodCalendar { get; set; }
    }
}
