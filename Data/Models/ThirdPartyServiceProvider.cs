using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class ThirdPartyServiceProvider
    {
        public ThirdPartyServiceProvider()
        {
            DimensionCreatorManufacturer = new HashSet<DimensionCreatorManufacturer>();
            Good = new HashSet<Good>();
            RentableGoodCalendar = new HashSet<RentableGoodCalendar>();
        }

        public long ThirdPartyServiceProviderId { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual BusinessOrganization ThirdPartyServiceProviderNavigation { get; set; }
        public virtual ICollection<DimensionCreatorManufacturer> DimensionCreatorManufacturer { get; set; }
        public virtual ICollection<Good> Good { get; set; }
        public virtual ICollection<RentableGoodCalendar> RentableGoodCalendar { get; set; }
    }
}
