namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_11 : PlatformScreenExceptionBase
    {
        public Ex_O_11(string message) : base(message)
        {
            ExceptionCode = "O_11";
            Message1 = "Minimum Price is blank";
            Message2 = "Minimum price may not be left blank.";
        }
 
    }
}