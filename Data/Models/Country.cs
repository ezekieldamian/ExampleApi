using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class Country
    {
        public Country()
        {
            StateOrProvince = new HashSet<StateOrProvince>();
        }

        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public string PostalAbbreviation { get; set; }
        public DateTime LastUpdateTimeStamp { get; set; }
        public byte[] RecordVersion { get; set; }

        [JsonIgnore]

        public virtual ICollection<StateOrProvince> StateOrProvince { get; set; }
    }
}
