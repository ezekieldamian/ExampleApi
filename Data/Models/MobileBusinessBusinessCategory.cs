using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class MobileBusinessBusinessCategory
    {
        public long MobileBusinessBusinessCategoryId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long BusinessCategoryFk { get; set; }
        public string OfferMode { get; set; }

        public virtual BusinessCategory BusinessCategoryFkNavigation { get; set; }
        [JsonIgnore]
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }

        //the following overrides are needed to prevent duplicates with the same fk

        //define equal as having the same business cat fk
        public bool Equals(MobileBusinessBusinessCategory other)
        {
            return null != other && (BusinessCategoryFk == other.BusinessCategoryFk && OfferMode == other.OfferMode);
        }

        //apples to apples
        public override bool Equals(object obj)
        {
            return Equals(obj as MobileBusinessBusinessCategory);
        }

        //get hash code used for comparison
        public override int GetHashCode()
        {
            return (int)BusinessCategoryFk;
        }
    }
}
