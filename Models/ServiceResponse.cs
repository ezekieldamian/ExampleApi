using Empr.CoreServicesApi.Data.Repositories;
using System;

namespace Empr.CoreServicesApi.Models
{
    ///the service response used for data transfer
    public class ServiceResponse<T>
    {
        public T Data { get; set; }

        public bool Success { get; set; } = true;

        public string Message { get; set; } = null;

        public PlatformScreenException Exception { get; set; } = null;

    }
}