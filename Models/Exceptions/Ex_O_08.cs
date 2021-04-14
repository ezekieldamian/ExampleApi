namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_08 : PlatformScreenExceptionBase
    {
        public Ex_O_08(string message) : base(message)
        {
            ExceptionCode = "O_08";
            Message1 = "Product description blank.";
            Message2 = "Product Description may not be left blank.";
        }
   }
}