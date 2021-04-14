using System.Threading.Tasks;
using Empr.CoreServicesApi.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Empr.CoreServicesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            this.authRepo = authRepo;
        }

        /// <summary>
        /// Register a new user and return the user id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            var response = await authRepo.Register(request);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        /// <summary>
        /// Login a user and return the authorization token
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            var response = await authRepo.Login(request.Username, request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        /// <summary>
        /// Refresh token without needing to log in again
        /// </summary>
        /// <param name="tokenDto"></param>
        /// <returns></returns>
        [HttpPost("refresh")]
        public IActionResult Refresh(TokenDto tokenDto)
        {
            var response = authRepo.Refresh(tokenDto);

            return Ok(response);
        }

        /// <summary>
        /// Delete refresh token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost("logout")]
        public async Task<IActionResult> Logout(TokenDto token)
        {
            await authRepo.Logout(token);

            return Ok();
        }
    }
}
