using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Models
{
    public class HealthCheckResponse
    {
        public string Status { get; set; }
        public string Description { get; set; }
        public IEnumerable<IndividualHealthCheckResponse> HealthChecks { get; set; }
        public TimeSpan HealthCheckDuration { get; set; }
    }
}
