namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_O_02 : PlatformScreenExceptionBase
    {
        public Ex_O_02(string message) : base(message)
        {
            ExceptionCode = "O_02";
            Message1 = "Add a new mobile business or edit business name, check the name for uniqueness";
            Message2 = "Sorry, that name is already taken.";
        }
    }
}