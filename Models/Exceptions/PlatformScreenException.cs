using System;

namespace Empr.CoreServicesApi.Data.Repositories
{
    public class PlatformScreenException
    {
        public PlatformScreenException(Exception ex)
        {
            switch (ex)
            {
                case PlatformScreenExceptionBase _:
                    //custom exception type
                    ExceptionCode = ((PlatformScreenExceptionBase)ex).ExceptionCode;
                    InnerException = ((PlatformScreenExceptionBase)ex).InnerException;
                    Message1 = ((PlatformScreenExceptionBase)ex).Message1;
                    Message2 = ((PlatformScreenExceptionBase)ex).Message2;
                    break;
                default:
                    //any other type of exception
                    ExceptionCode = "UNKNOWN";
                    InnerException = ex.InnerException?.Message;
                    Message1 = ex.Message;
                    Message2 = null;
                    break;
            }
        }

        public string ExceptionCode { get; private set; }
        public string InnerException { get; private set; }
        public string Message1 { get; private set; }
        public string Message2 { get; private set; }
    }
}