namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_17 : PlatformScreenExceptionBase
    {
        public Ex_O_17(string message) : base(message)
        {
            ExceptionCode = "O_17";
            Message1 = "Expected duration is blank";
            Message2 = "Expected duration may not be left blank.";
        }
    }
}