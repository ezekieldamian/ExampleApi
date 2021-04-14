using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Empr.CoreServicesApi.Models.DTO.Update
{
    public class MobileBusinessBusinessCategoryDto : IEquatable<MobileBusinessBusinessCategoryDto>
    {
        [JsonIgnore]
        public long MobileBusinessBusinessCategoryId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long BusinessCategoryFk { get; set; }
        public string OfferMode { get; set; }

        [JsonIgnore]
        public virtual BusinessCategoryDto BusinessCategoryFkNavigation { get; set; }

        public bool Equals(MobileBusinessBusinessCategoryDto other)
        {
            return null != other && BusinessCategoryFk == other.BusinessCategoryFk;
        }
    }
}