namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_16 : PlatformScreenExceptionBase
    {
        public Ex_O_16(string message) : base(message)
        {
            ExceptionCode = "O_16";
            Message1 = "Minimum and Maximum price too close together";
            Message2 = "Minimum and maximum price must be at least 25% apart.";
        }
    }
}