using Empr.CoreServicesApi.Data.Repositories.Interfaces;
using Empr.CoreServicesApi.Models;
using Empr.CoreServicesApi.Models.DTO;
using Empr.CoreServicesApi.Models.DTO.Request;
using Empr.CoreServicesApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Controllers
{

    //disabled security until we're ready to deploy to DEV
    //[Authorize(Roles = "ADM, MBE")]
    [Route("api/[controller]")]
    [ApiController]
    [ValidateModel]

    public class EmployeeController : ControllerBase
    {
        private readonly IMobileBusinessRepository repository;
        private readonly ILogger logger;

        public  EmployeeController(IMobileBusinessRepository repo, ILoggerFactory logger)
        {
            this.repository = repo;
            this.logger = logger.CreateLogger("EmployeeController");
        }

        /// <summary>
        /// Add business priority for Employee
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("businesspriority/add")]
        public async Task<IActionResult> AddBusinessPriority(BusinessPrioritiesRequestDto businessDto)
        {
            var response = await repository.AddBusinessPriority(businessDto, ActorType.Employee);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);
            return Ok(response);
        }

        /// <summary>
        /// Get all business priorities for Employee
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("businesspriority/get")]
        public async Task<IActionResult> GetBusinessPriorities()
        {
            var response = await repository.GetBusinessPriorities(ActorType.Employee);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Add info and create User for Employee
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("platformuser/signup")]
        public async Task<IActionResult> AddEmployee(PersonAsUserDto user)
        {
            var response = await repository.CreatePersonAsPlatformUser(user, ActorType.Employee);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Get Contact Details for Employee that matches the provided Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///
        //GET api/contactdetails/get
        [HttpGet]
        [Route("contactdetails/get/")]
        public async Task<IActionResult> GetContactDetailsById()
        {
            var response = await repository.GetContactDetails();

            //404 if not found
            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

            //todo map to dto
            return Ok(response);
        }

        /// <summary>
        /// Edit Contact Details for Employee
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("contactdetails/edit")]
        public async Task<IActionResult> EditContactDetails(MobileBusinessDto businessDto)
        {
            var response = await repository.EditContactDetails(businessDto);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }
    }
}
