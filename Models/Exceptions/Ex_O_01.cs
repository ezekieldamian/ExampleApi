namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_01 : PlatformScreenExceptionBase
    {
        public Ex_O_01(string message) : base(message)
        {
            ExceptionCode = "O_01";
            Message1 = "Business name was left blank on initial create or is being edited to blank";
            Message2 = "Business Name may not be left blank.";
        }
   }
}