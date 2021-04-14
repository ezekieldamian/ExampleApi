using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class StateOrProvince
    {
        public long StateOrProvinceId { get; set; }
        public long CountryFk { get; set; }
        public string StateOrProvinceName { get; set; }
        public string PostalAbbreviation { get; set; }
        public DateTime LastUpdateTimeStamp { get; set; }
        public byte[] RecordVersion { get; set; }
        public int? TimeZoneGreenwichOffset { get; set; }

        [JsonIgnore]
        public virtual Country CountryFkNavigation { get; set; }
    }
}
