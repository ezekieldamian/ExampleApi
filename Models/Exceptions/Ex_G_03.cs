namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_03 : PlatformScreenExceptionBase
    {
        public Ex_G_03(string message) : base(message)
        {
            ExceptionCode = "G_03";
            Message1 = "Duplicate username.";
            Message2 = "Sorry, username already taken.";
        }
 
    }
}