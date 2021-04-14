namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_02 : PlatformScreenExceptionBase
    {
        public Ex_G_02(string message) : base(message)
        {
            ExceptionCode = "G_02";
            Message1 = "Blank phone number.";
            Message2 = "Phone number may not be left blank.";
        }
  }
}