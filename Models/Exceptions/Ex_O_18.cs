namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_18 : PlatformScreenExceptionBase
    {
        public Ex_O_18(string message) : base(message)
        {
            ExceptionCode = "O_18";
            Message1 = "Expected duration is too low";
            Message2 = "Expected duration must be 5 or more minutes.";
        }
    }
}