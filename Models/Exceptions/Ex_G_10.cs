namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_10 : PlatformScreenExceptionBase
    {
            public Ex_G_10(string message) : base(message)
            {
                ExceptionCode = "G_10";
                Message1 = "No Party/PartyBankAccount info were provided.";
                Message2 = "Please complete the required information.";
            }
        
    }
}
