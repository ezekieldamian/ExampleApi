namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_04 : PlatformScreenExceptionBase
    {
        public Ex_O_04(string message) : base(message)
        {
            ExceptionCode = "O_04";
            Message1 = "Address Line 1 may not be left blank.";
            Message2 = "Please fill in address line 1.";
        }
   }
}