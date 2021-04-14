using System.ComponentModel;

namespace Empr.CoreServicesApi.Models
{
    public enum ActorType
    {
        [Description("ADM")]
        Admin,
        [Description("OWN")]
        Owner,
        [Description("MBE")]
        Employee,
        [Description("RC")]
        Customer,
        [Description("PE")]
        PlatformEmployee,
        [Description("MBA")]
        MobileBusinessAggregator
    }
}