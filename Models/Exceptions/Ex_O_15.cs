namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_15 : PlatformScreenExceptionBase
    {
        public Ex_O_15(string message) : base(message)
        {
            ExceptionCode = "O_15";
            Message1 = "Minimum greater than Maximum";
            Message2 = "Minimum must be less than maximum price must be at least 25% apart.";
        }
    }
}