namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_10 : PlatformScreenExceptionBase
    {
        public Ex_O_10(string message) : base(message)
        {
            ExceptionCode = "O_10";
            Message1 = "Image is blank";
            Message2 = "Image may not be left blank.";
        }
 
    }
}