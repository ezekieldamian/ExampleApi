namespace Empr.CoreServicesApi.Data.Repositories
{
    public class Ex_G_01 : PlatformScreenExceptionBase
    {
        public Ex_G_01(string message) : base(message)
        {
            ExceptionCode = "G_01";
            Message1 = "Blank username.";
            Message2 = "Username may not be left blank.";
        }

//G_02, ‘Blank phone number.’, ‘Phone number may not be left blank.”
//G_03, ‘Duplicate username.’, ‘Sorry, username already taken.”
//G_04, ‘Password too weak’, ‘’Please provide a password with letters (upper and lower), number(s) and special character(s).”
//G_05, ‘Duplicate phone number.’, ‘Sorry, I already have that phone number in the system.”
//G_06, ‘Username is not email.’, ‘Your user name must be an email.”

   }
}