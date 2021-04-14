using System;

namespace Empr.CoreServicesApi.Data.Repositories
{
    public class PlatformScreenExceptionBase : Exception
    {
        public PlatformScreenExceptionBase(string message) : base(message)
        {
        }

        public string ExceptionCode { get; set; }

        public new string InnerException { get; set; }

        public string Message1 { get; set; }

        public string Message2 { get; set; }

    }
}