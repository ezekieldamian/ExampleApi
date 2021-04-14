namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_09 : PlatformScreenExceptionBase
    {
        public Ex_O_09(string message) : base(message)
        {
            ExceptionCode = "O_09";
            Message1 = "Image is blank";
            Message2 = "Image may not be left blank.";
        }
 
    }
}