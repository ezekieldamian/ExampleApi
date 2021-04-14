namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_19 : PlatformScreenExceptionBase
    {
        public Ex_O_19(string message) : base(message)
        {
            ExceptionCode = "O_19";
            Message1 = "Logo blank.";
            Message2 = "Logo may not be left blank.";
        }
    }
}