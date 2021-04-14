namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_12 : PlatformScreenExceptionBase
    {
        public Ex_O_12(string message) : base(message)
        {
            ExceptionCode = "O_12";
            Message1 = "Maximum Price is blank";
            Message2 = "Maximum price may not be left blank.";
        }
    }
}