namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_07 : PlatformScreenExceptionBase
    {
        public Ex_G_07(string message) : base(message)
        {
            ExceptionCode = "G_07";
            Message1 = "Wrong code.";
            Message2 = "Wrong code, please try again or request another code.";
        }
    }
}