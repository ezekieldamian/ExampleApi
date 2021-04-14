namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_03 : PlatformScreenExceptionBase
    {
        public Ex_O_03(string message) : base(message)
        {
            ExceptionCode = "O_03";
            Message1 = "No good or service categories were provided.";
            Message2 = "Please fill in at least 1 good or service category.";
        }
    }
}