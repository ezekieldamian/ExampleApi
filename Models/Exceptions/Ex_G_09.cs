namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_09 : PlatformScreenExceptionBase
    {
        public Ex_G_09(string message) : base(message)
        {
            ExceptionCode = "G_09";
            Message1 = "Bad Password";
            Message2 = "Invalid password";
        }
    }
}