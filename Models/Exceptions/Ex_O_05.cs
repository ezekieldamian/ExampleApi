namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_05 : PlatformScreenExceptionBase
    {
        public Ex_O_05(string message) : base(message)
        {
            ExceptionCode = "O_05";
            Message1 = "Address city-state and zip left blank";
            Message2 = "we need city and state or at least zip on the address.";
        }
   }
}