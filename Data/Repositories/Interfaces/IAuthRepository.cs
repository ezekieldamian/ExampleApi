using Empr.CoreServicesApi.Controllers;
using Empr.CoreServicesApi.Models;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Data.Repositories.Interfaces
{
    public interface IAuthRepository
    {

        Task<ServiceResponse<TokenDto>> Login(string username, string password);
        Task<ServiceResponse<string>> Register(UserRegisterDto user);
        Task<bool> UserExists(string username);
        Task<ServiceResponse<TokenDto>> Refresh(TokenDto tokenDto);
        Task Logout(TokenDto token);
    }
}
