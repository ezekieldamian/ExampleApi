namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_13 : PlatformScreenExceptionBase
    {
        public Ex_O_13(string message) : base(message)
        {
            ExceptionCode = "O_13";
            Message1 = "Minimum Price too low";
            Message2 = "Minimum price must be $0.01 or greater.";
 
        }
    }
}