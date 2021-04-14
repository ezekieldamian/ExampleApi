namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_04 : PlatformScreenExceptionBase
    {
        public Ex_G_04(string message) : base(message)
        {
            ExceptionCode = "G_04";
            Message1 = "Password too weak";
            Message2 = "Please provide a password with letters (upper and lower), number(s) and special character(s).";
        }
    }
}