namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_05 : PlatformScreenExceptionBase
    {
        public Ex_G_05(string message) : base(message)
        {
            ExceptionCode = "G_05";
            Message1 = "Duplicate phone number.";
            Message2 = "Sorry, I already have that phone number in the system.";
        }
    }
}