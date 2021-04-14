namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_07 : PlatformScreenExceptionBase
    {
        public Ex_O_07(string message) : base(message)
        {
            ExceptionCode = "O_07";
            Message1 = "Monthly revenue left blank.";
            Message2 = "Please pick a revenue bracket.";
        }
   }
}