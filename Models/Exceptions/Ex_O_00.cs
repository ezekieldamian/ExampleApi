namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_00 : PlatformScreenExceptionBase
    {
        public Ex_O_00(string message) : base(message)
        {
            ExceptionCode = "O_00";
            Message1 = "Template";
            Message2 = "Template";
        }
   }
}