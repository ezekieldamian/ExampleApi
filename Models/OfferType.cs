using System.ComponentModel;

namespace Empr.CoreServicesApi.Models
{
    public enum OfferType
    {
        [Description("G")]
        Good,
        [Description("S")]
        Service,
        [Description("A")]
        Asset
    }
}