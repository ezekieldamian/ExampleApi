using System.Threading.Tasks;
using Empr.CoreServicesApi.Models.DTO.Create;
using Empr.CoreServicesApi.Models.DTO;
using Empr.CoreServicesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Empr.CoreServicesApi.Models.DTO.Response;
using Empr.CoreServicesApi.Data.Models;
using Empr.CoreServicesApi.Models.DTO.Request;
using Microsoft.Extensions.Logging;
using Empr.CoreServicesApi.Data.Repositories.Interfaces;
using Empr.CoreServicesApi.Utilities;
using Empr.CoreServicesApi.Models.DTO.Update;

namespace Empr.CoreServicesApi.Controllers
{
    //disabled security until we're ready to deploy to DEV
    //[Authorize(Roles = "ADM, OWN")]
    [Route("api/[controller]")]
    [ApiController]
    [ValidateModel]

    public class OwnerController : ControllerBase
    {
        private readonly IMobileBusinessRepository repository;
        private readonly ILogger logger;

        public OwnerController(IMobileBusinessRepository repo, ILoggerFactory logger)
        {
            repository = repo;
            this.logger = logger.CreateLogger("OwnerController");
        }

        /// <summary>
        /// Get All available Business Categories
        /// </summary>
        /// <returns></returns>
        //GET api/businesscategories/get/all
        [HttpGet]
        [Route("businesscategories/get/all")]
        public async Task<IActionResult> GetAllBusinessCategories()
        {
            var result = await repository.GetAllBusinessCategories();

            logger.LogInformation(result.Message);

            return Ok(result);
        }

        /// <summary>
        /// Checks whether the provided business name is available.
        /// </summary>
        /// <param name="org"></param>
        /// <returns></returns>
        //POST api/owner/businessname/check
        [HttpPost]
        [Route("businessname/check")]
        public IActionResult CheckBusinessNameFull(BusinessOrganizationCreateDto org)
        {
            //check if business name exists
            ServiceResponse<MobileBusinessDto> response = repository.CheckBusinessName(org);

            //move to a json-friendly dto
            var dto = new BusinessOrganizationResponseDto()
            {
                OrganizationName = org.OrganizationName,
                IsAvailable = response.Success
            };

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Checks whether the provided business name is available.
        /// This is a duplicate of the previous method designed to test
        /// whether it is faster with a more json-friendly dto.
        /// </summary>
        /// <param name="org"></param>
        /// <returns></returns>
        //POST api/owner/check
        [HttpPost]
        [Route("check")]
        public IActionResult CheckBusinessNameQuick(BusinessOrganizationCreateDto org)
        {
            //check if business name exists
            ServiceResponse<MobileBusinessDto> response = repository.CheckBusinessName(org);

            //move to a more json-friendly dto
            var dto = new BusinessOrganizationResponseDto()
            {
                OrganizationName = org.OrganizationName,
                IsAvailable = response.Success
            };

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(dto);
            }

            logger.LogInformation(response.Message);

            return Ok(dto);
        }

        /// <summary>
        /// Get the owner's business by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //GET api/owner/business/get/{id}
        [HttpGet]
        [Route("business/get/{id}")]
        public async Task<IActionResult> GetBusinessById(long id)
        {
            var business = await repository.GetBusinessById(id);

            //404 if not found
            if (business.Data == null)
            {
                logger.LogError(business.Message);

                return NotFound(business);
            }

            logger.LogInformation(business.Message);

            //todo map to dto
            return Ok(business);
        }

        /// <summary>
        /// Get a list of all countries in the database
        /// </summary>
        /// <returns></returns>
        //GET api/owner/countries/get/all
        [HttpGet("countries/get/all")]
        public async Task<IActionResult> GetAllCountries()
        {
            var countries = await repository.GetAllCountries();

            logger.LogInformation(countries.Message);

            return Ok(countries);
        }

        /// <summary>
        /// Get a list of all states or provinces for a particular country.
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        //GET api/owner/states/get/{countryId}
        [HttpGet("states/get/{countryId}")]
        public async Task<IActionResult> GetAllStates(int countryId)
        {
            var states = await repository.GetAllStates(countryId);

            logger.LogInformation(states.Message);

            return Ok(states);
        }

        /// <summary>
        /// Add/Edit business categories.
        /// Add business categories for a particular business if it's not there already.
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        //PUT api/owner/businesscategory/edit
        [HttpPut]
        [Route("businesscategory/edit")]
        public async Task<IActionResult> UpdateBusinessCategory(MobileBusinessDto businessDto)
        {
            var response = await repository.UpdateBusinessCategory(businessDto);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Add/Edit business categories.
        /// Add business categories for a particular business if it's not there already.
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        //PUT api/owner/businesscategory/edit
        [HttpPut]
        [Route("businesscategory/add/goods")]
        public async Task<IActionResult> AddGoodBusinessCategory(MobileBusinessDto businessDto)
        {
            var response = await repository.AddBusinessCategory(businessDto, OfferType.Good);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Add/Edit business categories.
        /// Add business categories for a particular business if it's not there already.
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        //PUT api/owner/businesscategory/edit
        [HttpPut]
        [Route("businesscategory/add/services")]
        public async Task<IActionResult> AddServiceBusinessCategory(MobileBusinessDto businessDto)
        {
            var response = await repository.AddBusinessCategory(businessDto, OfferType.Service);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Add/Edit business categories.
        /// Add business categories for a particular business if it's not there already.
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        //PUT api/owner/businesscategory/edit
        [HttpPut]
        [Route("businesscategory/add/assets")]
        public async Task<IActionResult> AddAssetBusinessCategory(MobileBusinessDto businessDto)
        {
            var response = await repository.AddBusinessCategory(businessDto, OfferType.Asset);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

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
            var response = await repository.CreateBusinessForExistingUser(business);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return CreatedAtAction(nameof(GetBusinessById), new { id = response.Data.MobileBusinessId }, response);
        }


        /// <summary>
        /// Add Business Priority
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        //PUT api/owner/businesspriority/add
        [HttpPut]
        [Route("businesspriority/add")]
        public async Task<IActionResult> AddBusinessPriority(BusinessPrioritiesRequestDto businessDto)
        {
            var response = await repository.AddBusinessPriority(businessDto, ActorType.Owner);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Add an address and service area data to mobile business
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("address/add")]
        public async Task<IActionResult> AddAddressAndServiceAreaData(MobileAddressAndServiceAreaDto data)
        {
            var response = await repository.AddAddressAndServiceAreaData(data);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Add Goods to mobile business
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("goods/add")]
        public async Task<IActionResult> AddGoods(AddProductsRequestDto data)
        {
            var response = await repository.AddGoods(data);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Add SErvices to Mobile Business
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("services/add")]
        public async Task<IActionResult> AddServices(AddProductsRequestDto data)
        {
            var response = await repository.AddServices(data);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Get All Business priorities
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("businesspriority/get")]
        public async Task<IActionResult> GetBusinessPriorities()
        {
            var response = await repository.GetBusinessPriorities(ActorType.Owner);

            if (response.Data == null)
            {
                logger.LogError(response.Message);

                return NotFound(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Save logo in Data Lake and return url
        /// </summary>
        /// <returns></returns>
        [HttpPost("logo/save")]
        public async Task<IActionResult> SaveImage()
        {
            var httpRequest = HttpContext.Request;

            var urls = await repository.SaveImage(httpRequest);

            if (urls == null)
            {
                logger.LogError(urls.Message);

                return BadRequest(urls);
            }

            logger.LogInformation(urls.Message);

            return Ok(urls);
        }

        /// <summary>
        /// Get all available  Platform Themes
        /// </summary>
        /// <returns></returns>
        [HttpGet("platformthemes/get")]
        public async Task<IActionResult> GetPlatformStoreThemes()
        {
            var response = await repository.GetPlatformStoreThemes();

            return Ok(response);
        }

        /// <summary>
        /// Get All available platform colors
        /// </summary>
        /// <returns></returns>
        [HttpGet("platformscreencolors/get")]
        public async Task<IActionResult> GetPlatformScreenColors()
        {
            var response = await repository.GetPlatformScreenColors();

            return Ok(response);
        }

        /// <summary>
        /// Update platform theme
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        [HttpPut("platformthemes/update")]
        public async Task<IActionResult> SetPlatformStoreThemes(MobileBusinessDto businessDto)
        {
            var response = await repository.SetPlatformStoreThemes(businessDto);

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Update platform screen color
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        [HttpPut("platformscreencolors/update")]
        public async Task<IActionResult> SetPlatformScreenColors(MobileBusinessDto businessDto)
        {
            var response = await repository.SetPlatformScreenColors(businessDto);

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Get all country codes
        /// </summary>
        /// <returns></returns>
        [HttpGet("countrycodes/get")]
        public async Task<IActionResult> GetCountryCodes()
        {
            var response = await repository.GetCountryCodes();

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Create the platform user for the Owner of the business
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("platformuser/signup")]
        public async Task<IActionResult> AddOwner(PersonAsUserDto user)
        {
            ServiceResponse<PersonAsUserDto> response = await repository.CreatePersonAsPlatformUser(user, ActorType.Owner);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Get bank account information for owner
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("bankaccount/get/{partyId}")]
        public async Task<IActionResult> GetBankAccountInfo(string partyId)
        {
            var response = await repository.GetBankAccountInfo(partyId);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Put bank account information for owner
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("bankaccount/update/{partyUuid}")]
        public async Task<IActionResult> UpdateBankAccountInfo(string partyUuid, PartyBankAccountUpdateDto businessDto)
        {
            ServiceResponse<string> response = await repository.UpdateBankAccountInfo(partyUuid, businessDto);

            if (!response.Success)
            {
                logger.LogError(response.Message);

                return BadRequest(response);
            }

            logger.LogInformation(response.Message);

            return Ok(response);
        }

        /// <summary>
        /// Get Contact Details for Owner that matches the provided Id
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
        /// Edit Contact Details for Owner
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
