namespace Empr.CoreServicesApi.Controllers
{
    public class UserRegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string PartyId { get; set; }
        public string FullName { get; set; }
        public string EmailTypeCode { get; set; }

    }
}