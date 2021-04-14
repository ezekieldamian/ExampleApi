namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_08 : PlatformScreenExceptionBase
    {
        public Ex_G_08(string message) : base(message)
        {
            ExceptionCode = "G_08";
            Message1 = "Bad Username";
            Message2 = "Invalid username.";
        }
    }
}