using Empr.CoreServicesApi.Data.Repositories.Interfaces;
using Empr.CoreServicesApi.Models.DTO;
using Empr.CoreServicesApi.Models.DTO.Create;
using Empr.CoreServicesApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Controllers
{

    //disabled security until we're ready to deploy to DEV
    [Authorize(Roles = "ADM, OWN")]
    [Route("api/[controller]")]
    [ApiController]
    [ValidateModel]
    public class BusinessesController : ControllerBase
    {
        private readonly IMobileBusinessRepository repository;
        private readonly ILogger logger;

        public BusinessesController(IMobileBusinessRepository repo, ILoggerFactory logger)
        {
            this.repository = repo;
            this.logger = logger.CreateLogger("BusinessController");
        }

        /// <summary>
        /// Gets all Mobile Businesses from the database
        /// Returns 200 OK on success
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        //GET api/businesses
        [HttpGet]
        [Route("get/all")]
        public async Task<IActionResult> GetAllBusinesses()
        {
            var response = await repository.GetAllBusinesses();

            logger.LogInformation(response.Message);

            //todo map to dto
            return Ok(response);
        }

        /// <summary>
        /// Get a Mobile Business that matches the provided Id
        /// Returns 404 Not Found if there are no matches
        /// Returns 200 OK on success
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///
        //GET api/businesses/{id}
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetBusinessById(long id)
        {
            var response = await repository.GetBusinessById(id);

            //404 if not found
            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            //todo map to dto
            return Ok(response);
        }

        /// <summary>
        /// Create new businesses in the database.
        /// Returns the new record and the new url in the header.
        /// </summary>
        /// <param name="business"></param>
        /// <returns></returns>
        //POST api/businesses/
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateBusiness(MobileBusinessCreateDto business)
        {
            var response = await repository.CreateBusiness(business);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return CreatedAtAction(nameof(GetBusinessById), new { id = response.Data.MobileBusinessId }, response);
        }

        /// <summary>
        /// Update a Business from the database using Entity Framework.
        /// Returns the updated record on success and 404 when not found.
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        //PUT api/businesses/edit
        [Route("edit")]
        [HttpPut] //todo: make it a PATCH?
        public async Task<IActionResult> UpdateBusiness(MobileBusinessDto businessDto)
        {
            var response = await repository.UpdateBusiness(businessDto);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Deletes a Business from the database.
        /// Returns the list of all businesses on successful delete.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //DELETE api/businesses/delete/{id}
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteBusiness(long id)
        {
            var response = await repository.DeleteBusiness(id);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

    }
}
