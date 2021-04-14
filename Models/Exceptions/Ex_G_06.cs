namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_06 : PlatformScreenExceptionBase
    {
        public Ex_G_06(string message) : base(message)
        {
            ExceptionCode = "G_06";
            Message1 = "Username is not email.";
            Message2 = "Your user name must be an email.";
        }
    }
}