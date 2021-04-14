using Empr.CoreServicesApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Empr.CoreServicesApi.Controllers
{
    //enabled security for testing
    //[Authorize(Roles = "ADM")]
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [ValidateModel]
    public class AdminController : ControllerBase
    {
        //[AllowAnonymous]
        [HttpGet("healthcheck")]
        public IActionResult HealthCheck()
        {
            return Ok(true);
        }
    }
}
