namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_14 : PlatformScreenExceptionBase
    {
        public Ex_O_14(string message) : base(message)
        {
            ExceptionCode = "O_14";
            Message1 = "Maximum Price too low";
            Message2 = "Maximum price must be $0.02 or greater.";
        }
    }
}