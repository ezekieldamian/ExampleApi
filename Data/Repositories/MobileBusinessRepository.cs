using AutoMapper;
using Empr.CoreServicesApi.Data.Models;
using Empr.CoreServicesApi.Data.Repositories.Interfaces;
using Empr.CoreServicesApi.Models;
using Empr.CoreServicesApi.Models.DTO;
using Empr.CoreServicesApi.Models.DTO.Create;
using Empr.CoreServicesApi.Models.DTO.Request;
using Empr.CoreServicesApi.Models.DTO.Response;
using Empr.CoreServicesApi.Models.DTO.Update;
using Empr.CoreServicesApi.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Data.Repositories
{
    public class MobileBusinessRepository : IMobileBusinessRepository
    {
        private readonly ReVyvvDataContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IConfiguration configuration;

        public MobileBusinessRepository(ReVyvvDataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.configuration = configuration;
        }

        private string GetUserUuid() => httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        private string GetUserRole() => httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.Role);
        private string GetUserName() => httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.Name);
        private string GetPartyId() => httpContextAccessor.HttpContext.User?.FindFirstValue("PartyId");

        /// <summary>
        /// Returns all Mobile Businesses in the database
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResponse<IEnumerable<MobileBusinessDto>>> GetAllBusinesses()
        {
            //create response
            var response = new ServiceResponse<IEnumerable<MobileBusinessDto>>();

            try
            {
                //get data
                var data = await GetAllBusinessRawData();

                //map to dto
                response.Data = data.Select(x => mapper.Map(x, new MobileBusinessDto())).ToList();
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        /// <summary>
        /// Get a particular Mobile Business with the id provided.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<MobileBusinessDto>> GetBusinessById(long id)
        {
            //create response
            var response = new ServiceResponse<MobileBusinessDto>();

            try
            {
                //get data
                var data = await GetBusinessByIdRawData(id);

                if (data == null)
                {
                    //not found
                    response.Success = false;
                    response.Message = $"Business id {id} not found.";
                }

                //map to dto
                response.Data = mapper.Map(data, new MobileBusinessDto());
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }
            return response;
        }

        public async Task<IEnumerable<MobileBusiness>> GetAllBusinessRawData()
        {
            var data = await context.MobileBusiness
                            .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation)
                            .Include(x => x.TaxItemTypeFkNavigation)
                            .Include(x => x.OwnerFkNavigation).ThenInclude(x => x.PersonAsUser)
                            .Include(x => x.ReturnAddressFkNavigation)
                            .Include(x => x.SelectedColorFkNavigation)
                            .Include(x => x.SelectedThemeFkNavigation)
                            .Include(x => x.MobileBusinessBusinessCategory).ThenInclude(x => x.BusinessCategoryFkNavigation)
                            .ToListAsync();

            //if admin, return all businesses
            if (GetUserRole() == ActorType.Admin.GetDescription())
            {
                return data;
            }

            //else, get only businesses that belong to this particular user
            return data.Where(x => IsThisMyBusiness(x));
        }

        private bool IsThisMyBusiness(MobileBusiness x)
        {
            var personFk = x.OwnerFkNavigation?.PersonAsUser?.FirstOrDefault(p => p.Uuid == GetUserUuid())?.PersonFk;
            return personFk != null && personFk == x.OwnerFk;
        }

        /// <summary>
        /// Get a particular product by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product> GetProductByIdRawData(long productId)
        {
            return await context.Product.FirstOrDefaultAsync(x => x.ProductId == productId);
        }

        /// <summary>
        /// Get all products for a business id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetAllProductsByBusinessIdRawData(long businessId)
        {
            return await context.Product.Where(x => x.MobileBusinessFk == businessId)
                .Include(x => x.Good)
                .Include(x => x.ProfessionalService)
                .ToListAsync();
        }

        public async Task<MobileBusiness> GetBusinessByIdRawData(long id)
        {
            //get data
            var data = await context.MobileBusiness
                        .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation)
                        .Include(x => x.TaxItemTypeFkNavigation)
                        .Include(x => x.OwnerFkNavigation).ThenInclude(x => x.PersonAsUser)
                        .Include(x => x.ReturnAddressFkNavigation).ThenInclude(x => x.PostOfficeAddressNavigation)
                        .Include(x => x.SelectedColorFkNavigation)
                        .Include(x => x.SelectedThemeFkNavigation)
                        .Include(x => x.Product)
                        .FirstOrDefaultAsync(x => x.MobileBusinessId == id);

            //if admin, return all businesses
            if (GetUserRole() == ActorType.Admin.GetDescription())
            {
                return data;
            }

            //else, get only businesses that belong to this particular user
            return IsThisMyBusiness(data)? data : null;
        }

        public async Task<Person> GetPersonById(long id)
        {
            //get data
            var data = await context.Person
                        .Include(x => x.PersonNavigation)
                        .FirstOrDefaultAsync(x => x.PersonId == id);

            return data;
        }

        public async Task<Party> GetPartyById(long id)
        {
            //get data
            var data = await context.Party
                        .FirstOrDefaultAsync(x => x.PartyId == id);
            return data;
        }

        public async Task<BusinessOrganization> GetBusinessOrganizationById(long id)
        {
            //get data
            var data = await context.BusinessOrganization
                        .FirstOrDefaultAsync(x => x.BusinessOrganizationId == id);
            return data;
        }

        public async Task<MobileBusiness> GetBusinessByNameRawData(string businessName)
        {
            //get data
            var data = await context.MobileBusiness
                        .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation)
                        .Include(x => x.TaxItemTypeFkNavigation)
                        .Include(x => x.OwnerFkNavigation)
                        .Include(x => x.ReturnAddressFkNavigation)
                        .Include(x => x.SelectedColorFkNavigation)
                        .Include(x => x.SelectedThemeFkNavigation)
                        .FirstOrDefaultAsync(x => x.MobileBusinessNavigation.OrganizationName == businessName.Replace("'", ""));

            //if admin, return all businesses
            if (GetUserRole() == ActorType.Admin.GetDescription())
            {
                return data;
            }

            //else, get only businesses that belong to this particular user
            return IsThisMyBusiness(data) ? data : null;
        }

        public async Task<MobileBusiness> GetBusinessByIdRawDataForUpdate(long id)
        {
            //get data
            var data = await context.MobileBusiness

                        //NOTE: ONLY INCLUDE PROPERTIES THAT WE WANT TO BE EDITABLE!!
                        //IE: DON'T WANT TO CHANGE NAME OF TAX BRACKET CAUSE THAT WILL AFFECT ALL BUSINESSES!!!

                        .FirstOrDefaultAsync(x => x.MobileBusinessId == id);

            //if admin, return all businesses
            if (GetUserRole() == ActorType.Admin.GetDescription())
            {
                return data;
            }

            //else, get only businesses that belong to this particular user
            return IsThisMyBusiness(data) ? data : null;
        }

        public async Task<MobileBusiness> GetBusinessByIdRawDataForDelete(long id)
        {
            //get data
            var data = await context.MobileBusiness
                        //no dependencies (don't want to accidentally delete them!!)
                        .FirstOrDefaultAsync(x => x.MobileBusinessId == id);

            //if admin, return all businesses
            if (GetUserRole() == ActorType.Admin.GetDescription())
            {
                return data;
            }

            //only admin should be able to delete
            return null;
        }

        private async Task<IEnumerable<PlatformObjective>> GetAllBusinessPrioritiesRawData(ActorType participantType)
        {
            var data = await context.PlatformObjective
                .Include(x => x.PlatformParticipantTypeFkNavigation)

                //filter by participant type
                .Where(x => x.PlatformParticipantTypeFkNavigation.ParticipantTypeIndicator == participantType.GetDescription())

                .ToListAsync();
            return data;
        }

        private async Task<Person> GetContactDetailsData()
        {
            //only include their own contact details
            var data = await context.Person
                .Include(x => x.PrimaryContactMechanismFkNavigation).ThenInclude(x => x.PostOfficeAddress)
                .FirstOrDefaultAsync(x => x.PlatformUserName == GetUserName());

            return data;
        }


        /// <summary>
        /// Create a new Mobile Business
        /// </summary>
        /// <param name="businessDto"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<MobileBusinessDto>> CreateBusinessForExistingUser(MobileBusinessCreateDto businessDto)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            try
            {
                //validation
                if (businessDto == null)
                {
                    throw new ArgumentNullException(nameof(businessDto));
                }

                if (businessDto.MobileBusinessNavigation == null)
                {
                    throw new ArgumentNullException(nameof(businessDto.MobileBusinessNavigation));
                }

                //make sure organization name is not blank
                Validation.CheckOrganizationNameIsNotBlank(businessDto.MobileBusinessNavigation?.OrganizationName);

                //check if organization name exists
                Validation.CheckOrganizationNameExists(context, businessDto.MobileBusinessNavigation.OrganizationName);

                var partyId = GetPartyId();
                var party = new Party();

                //if party doesn't exist
                if (partyId == null)
                {
                    //create new party
                    party = new Party
                    {
                        //create new guid
                        Uuid = Guid.NewGuid().ToString().ToUpper(),
                        CreateDate = DateTime.UtcNow
                    };

                    await context.SaveChangesAsync();
                }
                else
                {
                    //get party from db
                    party = await context.Party
                        .Include(x => x.BusinessOrganization)
                        .FirstOrDefaultAsync(x => x.Uuid == partyId);
                }

                if (party.BusinessOrganization == null)
                {
                    party.BusinessOrganization = new BusinessOrganization
                    {
                        BusinessOrganizationNavigation = party,
                        BusinessOrganizationId = party.PartyId,
                        OrganizationName = businessDto.MobileBusinessNavigation?.OrganizationName,
                        NonProfitFlag = businessDto.MobileBusinessNavigation.NonProfitFlag,
                        LastUpdateTimestamp = DateTime.UtcNow
                };

                    await context.SaveChangesAsync();
                }

                //then, create the new mobile business class
                var mobileBusiness = new MobileBusiness
                {
                    MobileBusinessNavigation = party.BusinessOrganization,
                    MobileBusinessId = party.PartyId,
                    TaxItemTypeFk = (await CheckCreateTaxId()).TaxItemTypeId,
                    OwnerTitle = businessDto.OwnerTitle,
                    ActiveFlag = "Y",
                    OwnerFkNavigation = await context.Person.FirstOrDefaultAsync(x => x.PlatformUserName == GetUserName()),
                    LastUpdateTimestamp = DateTime.UtcNow
                };

                //add to database
                var created = await context.MobileBusiness.AddAsync(mobileBusiness);

                //save changes
                await context.SaveChangesAsync();

                //already have the new record, no need to call database again
                response.Data = mapper.Map(created.Entity, new MobileBusinessDto()); //convert to dto

                //success
                response.Success = true;
                response.Message = $"Business id {created.Entity.MobileBusinessId} created.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        /// <summary>
        /// Create a new Mobile Business
        /// </summary>
        /// <param name="business"></param>
        /// <returns></returns>
        public ServiceResponse<MobileBusinessDto> CheckBusinessName(BusinessOrganizationCreateDto org)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            try
            {
                //make sure organization name is not blank
                Validation.CheckOrganizationNameIsNotBlank(org.OrganizationName);

                //check if organization name exists
                Validation.CheckOrganizationNameExists(context, org.OrganizationName);

                //success
                response.Data = null; //we don't care about data in this case
                response.Success = true;
                response.Message = $"Business name OK.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        /// <summary>
        /// Update Mobile Business
        /// </summary>
        /// <param name="business"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<MobileBusinessDto>> UpdateBusiness(MobileBusinessDto business)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            var data = await GetBusinessByIdRawDataForUpdate(business.MobileBusinessId);

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Business id {business.MobileBusinessId} not found.";

                return response;
            }

            try
            {
                //map to update dto
                var updateDto = mapper.Map(business, new MobileBusinessUpdateDto());

                //update data using automapper
                var updated = mapper.Map(updateDto, data);

                ////todo: be careful with automapper!!!
                ////only expose to the update dto the values we wanna change!!
                ////otherwise, we'll end up accidentally editing dependencies.

                ////testing
                //data.OwnerTitle = updateDto.OwnerTitle;
                //data.MobileBusinessNavigation.OrganizationName = updateDto.MobileBusinessNavigation.OrganizationName;
                //data.MobileBusinessNavigation.BusinessOrganizationNavigation.TokenBalance = updateDto.MobileBusinessNavigation.BusinessOrganizationNavigation.TokenBalance;
                //data.TaxItemTypeFkNavigation.TaxTypeName = updateDto.TaxItemTypeFkNavigation.TaxTypeName;

                //check if organization name exists
                Validation.CheckOrganizationNameExists(context, business.MobileBusinessNavigation?.OrganizationName);

                //update timestamp
                updated.LastUpdateTimestamp = DateTime.UtcNow;

                //todo: map business to dto
                await context.SaveChangesAsync();

                //map to dto and save data in response
                response.Data = mapper.Map(data, new MobileBusinessDto());

                response.Success = true;
                response.Message = $"Business id {business.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<MobileBusinessDto>> UpdateBusinessCategory(MobileBusinessDto business)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            var data = await context.MobileBusiness
                        .Include(x => x.MobileBusinessBusinessCategory)
                        .FirstOrDefaultAsync(x => x.MobileBusinessId == business.MobileBusinessId);

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Business id { business.MobileBusinessId } not found.";

                return response;
            }

            try
            {
                //check there's at least one bc
                Validation.CheckAtLeastOneCategory(business);

                //clear existing bcs
                //THIS IS NOT WORKING DUE TO FK CONTRAINTS!!!
                //data.MobileBusinessBusinessCategory.Clear();

                //filter out already existing fks
                var filteredCategories = business.MobileBusinessBusinessCategory
                    .Where(mbc =>
                        !data.MobileBusinessBusinessCategory.Contains(
                            //map dto model
                            mapper.Map(mbc, new MobileBusinessBusinessCategory())
                        )
                    ).ToList();

                //add new business - business category mtm fks
                foreach (var category in business.MobileBusinessBusinessCategory)
                {
                    data.MobileBusinessBusinessCategory.Add(new MobileBusinessBusinessCategory()
                    {
                        MobileBusinessFk = business.MobileBusinessId,
                        OfferMode = category.OfferMode,
                        BusinessCategoryFk = category.BusinessCategoryFk,
                    });
                }

                //update timestamp
                data.LastUpdateTimestamp = DateTime.UtcNow;

                //todo: map business to dto
                await context.SaveChangesAsync();

                //map to dto and save data in response
                response.Data = mapper.Map(data, new MobileBusinessDto());

                response.Success = true;
                response.Message = $"Business id {business.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<MobileBusinessDto>> AddBusinessCategory(MobileBusinessDto business, OfferType offerType)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            var data = await context.MobileBusiness
                        .Include(x => x.MobileBusinessBusinessCategory)
                        .FirstOrDefaultAsync(x => x.MobileBusinessId == business.MobileBusinessId);

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Business id { business.MobileBusinessId } not found.";

                return response;
            }

            try
            {
                //check there's at least one bc
                Validation.CheckAtLeastOneCategory(business);

                //todo move this to validation class
                var offerMode = string.Empty;

                //make sure bcs are the right offer type
                if (business.MobileBusinessBusinessCategory.Any(x =>
                    {
                        offerMode = x.OfferMode;
                        return x.OfferMode != offerType.GetDescription();
                    }
                ))
                {
                    throw new Exception($"Invalid Offer Mode: {offerMode}");
                }

                //filter out already existing fks
                var filteredCategories = business.MobileBusinessBusinessCategory
                    .Where(mbc =>
                        !data.MobileBusinessBusinessCategory.Contains(
                            //map dto model
                            mapper.Map(mbc, new MobileBusinessBusinessCategory())
                        )
                    ).ToList();

                //add new business - business category mtm fks
                foreach (var category in filteredCategories)
                {
                    data.MobileBusinessBusinessCategory.Add(new MobileBusinessBusinessCategory()
                    {
                        MobileBusinessFk = business.MobileBusinessId,
                        OfferMode = category.OfferMode,
                        BusinessCategoryFk = category.BusinessCategoryFk
                    });
                }

                //update timestamp
                data.LastUpdateTimestamp = DateTime.UtcNow;

                //todo: map business to dto
                await context.SaveChangesAsync();

                //map to dto and save data in response
                response.Data = mapper.Map(data, new MobileBusinessDto());

                response.Success = true;
                response.Message = $"Business id {business.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        /// <summary>
        /// Check if General Taxable tax record exists, if not create one.
        /// </summary>
        /// <returns></returns>
        private async Task<TaxItemType> CheckCreateTaxId()
        {
            var taxName = "General Taxable";
            var tax = new TaxItemType();

            try
            {
                //if exists, return it. This will throw an exception if not exists
                tax = await context.TaxItemType.FirstAsync(x => x.TaxTypeName == taxName);
            }
            catch
            {
                //create tax id if not present
                tax.TaxTypeName = taxName;
                tax.LastUpdateTimestamp = DateTime.UtcNow;

                //save new tax record to the db
                tax = (await context.TaxItemType.AddAsync(tax)).Entity;
                await context.SaveChangesAsync();
            }

            return tax;
        }

        /// <summary>
        /// Delete a Mobile Business
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<IEnumerable<MobileBusinessDto>>> DeleteBusiness(long id)
        {
            var response = new ServiceResponse<IEnumerable<MobileBusinessDto>>();

            var business = await GetBusinessByIdRawData(id);

            if (business == null)
            {
                response.Success = false;
                response.Message = $"Business id {id} not found.";

                return response;
            }

            try
            {
                context.MobileBusiness.Remove(business);

                await context.SaveChangesAsync();

                response.Data = null;

                response.Success = true;
                response.Message = $"Business id {id} deleted.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<BusinessCategoryDto>>> GetAllBusinessCategories()
        {
            //create response
            var response = new ServiceResponse<IEnumerable<BusinessCategoryDto>>();

            try
            {
                //get data
                var data = await GetAllBusinessCategoriesRawData();

                //map to dto
                response.Data = data.Select(x => mapper.Map(x, new BusinessCategoryDto())).ToList();
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        private async Task<IEnumerable<BusinessCategory>> GetAllBusinessCategoriesRawData()
        {
            return await context.BusinessCategory.ToListAsync();
        }

        private async Task<IEnumerable<Country>> GetAllCountriesRawData()
        {
            return await context.Country.ToListAsync();
        }

        private async Task<IEnumerable<StateOrProvince>> GetAllStatesRawData(int countryId)
        {
            return await context.StateOrProvince
                .Where(x => x.CountryFk == countryId)
                .ToListAsync();
        }

        public ServiceResponse<MobileBusinessDto> AddMobileBusiness(MobileBusinessCreateDto business)
        {
            //create response
            var response = new ServiceResponse<MobileBusinessDto>();

            try
            {
                var sp = new MobileBusinessSprocParams()
                {
                    ActorType = "OWN",
                    TransactionType = "add",
                    Payload = $"organization_name {business.MobileBusinessNavigation.OrganizationName}||"
                };

                var result = CreateBusiness(sp);

                if (result.Trim() == "Duplicate Row.")
                {
                    throw new Ex_O_02(result);
                }
                if (result.Trim().Contains("organization_name"))
                {
                    throw new Ex_O_01(result);
                }
                if (result.Trim() != "OK")
                {
                    throw new Exception(result);
                }

                //get new record and convert to dto
                //var data = await GetBusinessByNameRawData(business.MobileBusinessNavigation.OrganizationName);
                response.Data = null;// mapper.Map(data, new MobileBusinessDto());

                //success
                response.Success = true;
                response.Message = $"Business created.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public string CreateBusiness(MobileBusinessSprocParams args)
        {
            var outParam = new SqlParameter
            {
                ParameterName = "@arg_result",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Output,
                Size = 1024
            };

            var sql = "exec ods.sp_mobile_business @arg_actor_type, @arg_user_id, @arg_parent_id, @arg_record_id, " +
                "@arg_transaction_type, @arg_payload, @arg_result OUT";

            var result = context.Database.ExecuteSqlRaw(sql,
                new SqlParameter("arg_actor_type", args.ActorType),
                new SqlParameter("arg_user_id", args.UserId),
                new SqlParameter("arg_parent_id", args.ParentId),
                new SqlParameter("arg_record_id", args.RecordId),
                new SqlParameter("arg_transaction_type", args.TransactionType),
                new SqlParameter("arg_payload", args.Payload.Replace("'", "")),
                outParam
                );

            return outParam.Value.ToString();
        }

        public async Task<ServiceResponse<IEnumerable<CountryDto>>> GetAllCountries()
        {
            //create response
            var response = new ServiceResponse<IEnumerable<CountryDto>>();

            try
            {
                //get data
                var data = await GetAllCountriesRawData();

                //map to dto
                response.Data = data.OrderBy(x => x.CountryName).Select(x => mapper.Map(x, new CountryDto())).ToList();
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<StateOrProvinceDto>>> GetAllStates(int countryId)
        {
            //create response
            var response = new ServiceResponse<IEnumerable<StateOrProvinceDto>>();

            try
            {
                //get data
                var data = await GetAllStatesRawData(countryId);

                //map to dto
                response.Data = data.OrderBy(x => x.StateOrProvinceName).Select(x => mapper.Map(x, new StateOrProvinceDto())).ToList();
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<MobileBusinessRioritiesResponseDto>> AddBusinessPriority(BusinessPrioritiesRequestDto requestDto, ActorType participantType)
        {
            var response = new ServiceResponse<MobileBusinessRioritiesResponseDto>();

            var business = await context.MobileBusiness
                        .Include(x => x.MobileBusinessNavigation) //the business organization fk
                        .ThenInclude(x => x.BusinessOrganizationNavigation) //party
                        .FirstOrDefaultAsync(x => x.MobileBusinessId == requestDto.MobileBusinessId);

            var participant = await context.PlatformParticipantType.FirstOrDefaultAsync(x => x.ParticipantTypeIndicator == participantType.GetDescription());

            var priorities = await context.PlatformObjective
                    .Include(x => x.PlatformParticipantTypeFkNavigation)
                    //filter by participant type
                    .Where(x => x.PlatformParticipantTypeFkNavigation.ParticipantTypeIndicator == participantType.GetDescription())
                    .ToListAsync();

            if (business == null)
            {
                response.Success = false;
                response.Message = $"Business id { requestDto.MobileBusinessId } not found.";

                return response;
            }

            try
            {
                foreach (var priority in requestDto.Priorities)
                {
                    business.MobileBusinessNavigation.BusinessOrganizationNavigation.PartyPlatformObjectivePriority.Add(new PartyPlatformObjectivePriority()
                    {
                        PartyFk = business.MobileBusinessNavigation.BusinessOrganizationNavigation.PartyId,
                        ObjectivePriority = priority.PriorityNumber,
                        PlatformObjectiveFk = priority.PlatformObjectiveId,
                        PlatformParticipantTypeFk = participant.PlatformParticipantTypeId
                    });
                }

                //update timestamp
                business.LastUpdateTimestamp = DateTime.UtcNow;

                //update mobile business
                context.MobileBusiness.Update(business);

                //todo: map business to dto
                await context.SaveChangesAsync();

                //map to dto and save data in response
                response.Data = new MobileBusinessRioritiesResponseDto()
                {
                    MobileBusinessId = business.MobileBusinessId,
                    Priorities = business.MobileBusinessNavigation.BusinessOrganizationNavigation.PartyPlatformObjectivePriority
                                    .Select(x => mapper.Map(x, new PartyPlatformObjectivePriorityDto()))
                };

                response.Success = true;
                response.Message = $"Business id {requestDto.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<MobileBusinessDto>> AddAddressAndServiceAreaData(MobileAddressAndServiceAreaDto data)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            try
            {
                //Validation
                if (data == null)
                {
                    throw new ArgumentNullException(nameof(data));
                }

                //check if business exists
                Validation.CheckBusinessIdExists(context, (int)data.MobileBusinessId);

                //get the existing mobile business record
                var mb = await GetBusinessByIdRawData(data.MobileBusinessId);

                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    //create new business location
                    var bl = new BusinessLocation
                    {
                        MobileBusinessFk = mb.MobileBusinessId,
                        LocationName = "Headquarters",
                        HeadquartersFlag = "Y",
                        LocationStartDate = DateTime.UtcNow,
                        GreenwichOffset = 0,
                        LastUpdateTimestamp = DateTime.UtcNow
                    };

                    await context.BusinessLocation.AddAsync(bl);

                    //create new contact mechanism uuid
                    var cm = new ContactMechanism()
                    {
                        Uuid = Guid.NewGuid().ToString(),
                        LastUpdateTimestamp = DateTime.UtcNow
                    };

                    await context.ContactMechanism.AddAsync(cm);

                    //need to save here to get the contact mechanism id!!
                    await context.SaveChangesAsync();

                    //create new party contact mechanism
                    var pcm = new PartyContactMechanism()
                    {
                        PartyFk = mb.MobileBusinessNavigation.BusinessOrganizationNavigation.PartyId,
                        ContactMechanismFk = cm.ContactMechanismId,
                        LastUpdateTimestamp = DateTime.UtcNow
                    };

                    await context.PartyContactMechanism.AddAsync(pcm);

                    //now that we have contact mechanism relationship, we can create the post office address
                    var poa = new PostOfficeAddress
                    {
                        PostOfficeAddressId = cm.ContactMechanismId,
                        AddressLine1 = data.AddressLine1,
                        AddressLine2 = data.AddressLine2,
                        AddressLine3 = data.AddressLine3,
                        City = data.City,
                        StatePostalCode = data.StatePostalCode,
                        ZipCode = data.ZipCode,
                        LastUpdateTimestamp = DateTime.UtcNow
                    };

                    //Add to database
                    await context.PostOfficeAddress.AddAsync(poa);

                    //update return address fk
                    mb.ReturnAddressFk = poa.PostOfficeAddressId;

                    //update timestamp
                    mb.LastUpdateTimestamp = DateTime.UtcNow;

                    //Add to database
                    context.MobileBusiness.Update(mb);

                    //Save changes
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                }

                response.Data = mapper.Map(await GetBusinessByIdRawData(mb.MobileBusinessId), new MobileBusinessDto());

                //Success
                response.Success = true;
                response.Message = $"Business id {data.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ProductDto>>> AddGoods(AddProductsRequestDto requestDto)
        {
            var response = new ServiceResponse<IEnumerable<ProductDto>>();

            //get data
            var data = await GetBusinessByIdRawDataForUpdate(requestDto.MobileBusinessId);

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Business id {requestDto.MobileBusinessId} not found.";

                return response;
            }

            try
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    var productsToAdd = new List<Product>();

                    foreach (var product in requestDto.Products)
                    {
                        var prod = new Product()
                        {
                            MobileBusinessFk = data.MobileBusinessId,
                            TextDescription = product.TextDescription,
                            MinimumPrice = product.MinimumPrice,
                            MaximumPrice = product.MaximumPrice,
                            OkForPickupFlag = product.OkForPickupFlag,
                            OkForShipFlag = product.OkForShipFlag,
                            LastUpdateTimestamp = DateTime.UtcNow
                        };

                        await context.Product.AddAsync(prod);

                        await context.SaveChangesAsync();

                        var good = new Good()
                        {
                            GoodId = prod.ProductId,
                            WeightInPounds = product.Good.WeightInPounds,
                            QuantityOnHand = product.Good.QuantityOnHand,
                            LastUpdateTimestamp = DateTime.UtcNow
                        };

                        await context.Good.AddAsync(good);
                    }

                    //update timestamp
                    data.LastUpdateTimestamp = DateTime.UtcNow;

                    //Save changes
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                }

                var allProducts = await GetAllProductsByBusinessIdRawData(requestDto.MobileBusinessId);
                response.Data = allProducts.Select(x => mapper.Map(x, new ProductDto()));

                //Success
                response.Success = true;
                response.Message = $"Business id {data.MobileBusinessId} updated.";

            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ProductDto>>> AddServices(AddProductsRequestDto requestDto)
        {
            var response = new ServiceResponse<IEnumerable<ProductDto>>();

            //get data
            var data = await GetBusinessByIdRawDataForUpdate(requestDto.MobileBusinessId);

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Business id {requestDto.MobileBusinessId} not found.";

                return response;
            }

            try
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    var productsToAdd = new List<Product>();

                    foreach (var product in requestDto.Products)
                    {
                        var prod = new Product()
                        {
                            MobileBusinessFk = data.MobileBusinessId,
                            TextDescription = product.TextDescription,
                            MinimumPrice = product.MinimumPrice,
                            MaximumPrice = product.MaximumPrice,
                            LastUpdateTimestamp = DateTime.UtcNow
                        };

                        await context.Product.AddAsync(prod);

                        await context.SaveChangesAsync();

                        var ps = new ProfessionalService()
                        {
                            ProfessionalServiceId = prod.ProductId,
                            ExpectedDurationInMinutes = product.ProfessionalService.ExpectedDurationInMinutes,
                            LastUpdateTimestamp = DateTime.UtcNow
                        };

                        await context.ProfessionalService.AddAsync(ps);
                    }

                    //update timestamp
                    data.LastUpdateTimestamp = DateTime.UtcNow;

                    //Save changes
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                }

                var allProds = await GetAllProductsByBusinessIdRawData(requestDto.MobileBusinessId);
                response.Data = allProds.Select(x => mapper.Map(x, new ProductDto()));

                //Success
                response.Success = true;
                response.Message = $"Business id {data.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<PlatformObjectiveDto>>> GetBusinessPriorities(ActorType participantType)
        {
            //create response
            var response = new ServiceResponse<IEnumerable<PlatformObjectiveDto>>();

            var data = await GetAllBusinessPrioritiesRawData(participantType);

            //map to dto
            response.Data = data.Select(x => mapper.Map(x, new PlatformObjectiveDto())).ToList();

            return response;
        }

        public async Task<ServiceResponse<MobileBusinessUpdateLogoResponeDto>> SaveImage(HttpRequest request)
        {
            var response = new ServiceResponse<MobileBusinessUpdateLogoResponeDto>();

            try
            {
                //get business id and business name
                var businessId = request.Form.ToList().FirstOrDefault(x => x.Key == "businessId").Value;
                var businessName = request.Form.ToList().FirstOrDefault(x => x.Key == "businessName").Value;

                //remove unsupported characters
                businessName = businessName.ToString().Replace("'", "");

                //get data lake url from config
                var baseUrl = configuration.GetSection("AppSettings:DataLakeLogoUploadUrl").Value;

                //post to the following url:
                var saveUrl = $"{baseUrl}?business_id={businessId}&business_name={businessName}";

                //create the form
                var form = new MultipartFormDataContent();

                //create the http client
                var client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);

                //save image to this url:
                //http://revyvvetldev.azurewebsites.net/data_api/data_services/business_logo_upload?business_id=18&business_name=Test

                //image will be sent in the body of the request as a form-data
                //with a key of "image" and a value of the image itself.

                ByteArrayContent fileContent;

                //get the file from the From in the request
                var file = request.Form.Files.FirstOrDefault(x => x.Name == "image");

                if (file == null)
                {
                    throw new Exception("image file cannot be null.");
                }

                //create a byte array of the file contents
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    fileContent = new ByteArrayContent(fileBytes);
                }

                //set content type and add file content
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                form.Add(fileContent, file.Name, file.FileName);

                //post and wait for response
                var responseFromClient = await client.PostAsync(saveUrl, form);

                //deserialize url from response content
                var json = JsonConvert.DeserializeObject(await responseFromClient.Content.ReadAsStringAsync());

                //parse business id
                int.TryParse(businessId.ToString(), out var id);

                //update logo url and return response
                return await UpdateImageUrlAsync(id, json.ToString());
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        private async Task<ServiceResponse<MobileBusinessUpdateLogoResponeDto>> UpdateImageUrlAsync(int businessId, string businessUrl)
        {
            var response = new ServiceResponse<MobileBusinessUpdateLogoResponeDto>();

            //get the business from id
            var data = await GetBusinessByIdRawData(businessId);

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Business id {businessId} not found.";

                return response;
            }

            try
            {
                //save logo url
                data.LogoUrl = businessUrl;

                //update timestamp
                data.LastUpdateTimestamp = DateTime.UtcNow;

                //Add to database
                context.MobileBusiness.Update(data);

                //Save changes
                await context.SaveChangesAsync();

                //map to dto and save data in response
                response.Data = mapper.Map(data, new MobileBusinessUpdateLogoResponeDto());
                response.Success = true;
                response.Message = $"Image uploaded successfully.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<IEnumerable<PlatformStoreThemeDto>> GetPlatformStoreThemes()
        {
            //get data
            var data = await context.PlatformStoreTheme.ToListAsync();

            //convert to dto
            return data.Select(x => mapper.Map(x, new PlatformStoreThemeDto())).ToList();
        }

        public async Task<IEnumerable<PlatformScreensMainColorDto>> GetPlatformScreenColors()
        {
            //get data
            var data = await context.PlatformScreensMainColor.ToListAsync();

            //convert to dto
            return data.Select(x => mapper.Map(x, new PlatformScreensMainColorDto())).ToList();
        }

        public async Task<ServiceResponse<MobileBusinessDto>> SetPlatformScreenColors(MobileBusinessDto mobileBusinessDto)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            //get data
            var data = await GetBusinessByIdRawDataForUpdate(mobileBusinessDto.MobileBusinessId);

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Business id {mobileBusinessDto.MobileBusinessId} not found.";

                return response;
            }

            try
            {
                if (mobileBusinessDto.SelectedColorFk == null)
                {
                    throw new Exception($"No color selection has been made.");
                }

                data.SelectedColorFk = mobileBusinessDto.SelectedColorFk;

                //update timestamp
                data.LastUpdateTimestamp = DateTime.UtcNow;

                //Add to database
                context.MobileBusiness.Update(data);

                //Save changes
                await context.SaveChangesAsync();

                //map to dto and save data in response
                response.Data = mapper.Map(data, new MobileBusinessDto());
                response.Success = true;
                response.Message = $"Business id {mobileBusinessDto.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<MobileBusinessDto>> SetPlatformStoreThemes(MobileBusinessDto mobileBusinessDto)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            //get data
            var data = await GetBusinessByIdRawDataForUpdate(mobileBusinessDto.MobileBusinessId);

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Business id {mobileBusinessDto.MobileBusinessId} not found.";

                return response;
            }

            try
            {
                if (mobileBusinessDto.SelectedThemeFk == null) {
                    throw new Exception($"No theme selection has been made.");
                }

                data.SelectedThemeFk = mobileBusinessDto.SelectedThemeFk;

                //update timestamp
                data.LastUpdateTimestamp = DateTime.UtcNow;

                //Add to database
                context.MobileBusiness.Update(data);

                //Save changes
                await context.SaveChangesAsync();

                //map to dto and save data in response
                response.Data = mapper.Map(data, new MobileBusinessDto());
                response.Success = true;
                response.Message = $"Business id {mobileBusinessDto.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<CountryCodeDto>>> GetCountryCodes()
        {
            //  Argentina   54  AR / ARG    41,343,201  2,766,890   484.6 Billion
            //Mexico  52  MX / MEX    112,468,855 1,972,550   1.327 Trillion
            //United States   1   US / USA    310,232,863 9,629,091   16.72 Trillion
            //        Brazil  55  BR / BRA    201,103,330 8,511,965   2.19 Trillion

            //todo get all other countries
            var response = new ServiceResponse<IEnumerable<CountryCodeDto>>();

            //get data
            var data = await GetAllCountriesRawData();

            if (data == null)
            {
                response.Success = false;
                response.Message = $"Country data not found.";

                return response;
            }

            try
            {
                //to do get real data from db
                var argentina = data.Where(x => x.CountryName == "Argentina").FirstOrDefault();
                var brasil = data.Where(x => x.CountryName == "Brazil").FirstOrDefault();
                var usa = data.Where(x => x.CountryName == "United States of America").FirstOrDefault();
                var mexico = data.Where(x => x.CountryName == "Mexico").FirstOrDefault();

                //get just a few contries for now
                var countrycodes = new List<CountryCodeDto>()
                {
                    new CountryCodeDto()
                    {
                        CountryId = (int)argentina.CountryId,
                        CountryAreaCode = "+54",
                        PostalCode = argentina.PostalAbbreviation,
                        CountryName = argentina.CountryName
                    },
                    new CountryCodeDto()
                    {
                        CountryId = (int)brasil.CountryId,
                        CountryAreaCode = "+55",
                        PostalCode = brasil.PostalAbbreviation,
                        CountryName = brasil.CountryName
                    },
                    new CountryCodeDto()
                    {
                        CountryId = (int)usa.CountryId,
                        CountryAreaCode = "+1",
                        PostalCode = usa.PostalAbbreviation,
                        CountryName = usa.CountryName
                    },
                    new CountryCodeDto()
                    {
                        CountryId = (int)mexico.CountryId,
                        CountryAreaCode = "+52",
                        PostalCode = mexico.PostalAbbreviation,
                        CountryName = mexico.CountryName
                    }
                };

                response.Data = countrycodes.OrderBy(x => x.CountryAreaCode);
                response.Success = true;
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        //OBSOLETE: we're replacing this with new Auth
        public async Task<ServiceResponse<PersonAsUserDto>> CreatePersonAsPlatformUser(PersonAsUserDto user, ActorType actorType)
        {
            //Encrypt password
            string encryptedPassword = "";

            encryptedPassword = Encryption.Encrypt(user.PlatformPassword, true);
            //encryptedPassword = Encryption.Decrypt(user.PlatformPassword, true);

            var response = new ServiceResponse<PersonAsUserDto>();

            try
            {
                //Validation
                if (user == null)
                {
                    throw new ArgumentNullException(nameof(user));
                }

                var personId = 0;

                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    Person person = null;

                    //every person is a new party!!

                    //get mobile business
                    var business = await GetBusinessByIdRawData((long)user.MobileBusinessFk);

                    var party = await context.Party.FirstOrDefaultAsync(x => x.PartyId == user.MobileBusinessFk);

                    //Verify if there's an existing party associated with user.MobileBusinessFk
                    if (party == null)
                    {
                        //create new party
                        var p = new Party
                        {
                            //create new guid
                            Uuid = Guid.NewGuid().ToString().ToUpper(),
                            CreateDate = DateTime.UtcNow,
                            LastUpdateTimestamp = DateTime.UtcNow
                        };

                        await context.Party.AddAsync(p);

                        //save to get the party id
                        await context.SaveChangesAsync();

                        //create person
                        //'platform_user_name brad@aol.com||full_name Brad||'
                        //insert into ods.person ( person_id , platform_user_name, full_name ) values ( 34, 'brad@aol.com', 'Brad' );

                        person = new Person
                        {
                            PersonId = p.PartyId,
                            FullName = user.Person.FullName,
                            //PrimaryContactMechanismFk = cmID,
                            PlatformUserName = user.Contact.EmailAddress.Email,
                            LastUpdateTimestamp = DateTime.UtcNow
                        };
                    }
                    else {

                        person = new Person
                        {
                            PersonId = party.PartyId,
                            FullName = user.Person.FullName,
                            //PrimaryContactMechanismFk = cmID,
                            PlatformUserName = user.Contact.EmailAddress.Email,
                            LastUpdateTimestamp = DateTime.UtcNow
                        };
                    }

                    await context.Person.AddAsync(person);

                    //save to get the person id
                    await context.SaveChangesAsync();

                    //create person as user
                    //insert into ods.person_as_user      ( person_fk, uuid  ) values ( 34, 'E448C4AB-6D85-40F1-A5F5-78EC68CA891A' );

                    var participantType = await context.PlatformParticipantType.Where(x => x.ParticipantTypeIndicator == actorType.GetDescription()).FirstOrDefaultAsync();

                    var personAsUser = new PersonAsUser
                    {
                        PersonFk = person.PersonId,
                        Uuid = Guid.NewGuid().ToString().ToUpper(),
                        MobileBusinessFk = user.MobileBusinessFk,
                        PasswordBin = Encoding.UTF8.GetBytes(encryptedPassword),
                        PlatformParticipantTypeFk = participantType.PlatformParticipantTypeId,
                        LastUpdateTimestamp = DateTime.UtcNow
                    };

                    await context.PersonAsUser.AddAsync(personAsUser);

                    //save to get the person as user id
                    await context.SaveChangesAsync();

                    //then, update the mobile business class
                    if (actorType == ActorType.Owner)
                    {
                        //update owner but only if correct actor type
                        business.OwnerFk = person.PersonId;

                        //update timestamp
                        business.LastUpdateTimestamp = DateTime.UtcNow;
                    }

                    //save the person id
                    personId = (int)person.PersonId;

                    //create new contact mechanism uuid
                    var cm = new ContactMechanism()
                    {
                        Uuid = Guid.NewGuid().ToString(),
                        LastUpdateTimestamp = DateTime.UtcNow
                    };

                    await context.ContactMechanism.AddAsync(cm);

                    //need to save here to get the contact mechanism id!!
                    await context.SaveChangesAsync();

                    //create Email Address
                    var email = new EmailAddress()
                    {
                        EmailAddressId = cm.ContactMechanismId,
                        Email = user.Contact.EmailAddress.Email,
                        EmailTypeCode = user.Contact.EmailAddress.EmailTypeCode,
                        LastUpdateTimestamp = DateTime.UtcNow
                    };

                    await context.EmailAddress.AddAsync(email);

                    //Save changes
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                }

                //response.Data = mapper.Map(await GetBusinessByIdRawData(mb.MobileBusinessId), new MobileBusinessDto());

                //Success
                response.Success = true;
                response.Message = $"Person id {personId} updated.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<PersonDto>> GetContactDetails()
        {
            //create response
            var response = new ServiceResponse<PersonDto>();

            var data = await GetContactDetailsData();

            //map to dto
            response.Data = mapper.Map(data, new PersonDto());

            return response;
        }

        public async Task<ServiceResponse<MobileBusinessDto>> EditContactDetails(MobileBusinessDto businessDto)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            try
            {
                //Validation
                if (businessDto == null)
                {
                    throw new ArgumentNullException(nameof(businessDto));
                }

                var party = GetPartyId();
                if (party == null)
                {
                    //return empty response
                    return response;
                }

                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    var person = await context.MobileBusiness
                        .Include(x => x.OwnerFkNavigation)
                        .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation)
                        .FirstOrDefaultAsync(x => x.MobileBusinessNavigation.BusinessOrganizationNavigation.Uuid == party);

                    var contMech = await context.MobileBusiness
                        .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation)
                        .Include(x => x.OwnerFkNavigation).ThenInclude(x => x.PrimaryContactMechanismFkNavigation)
                        .FirstOrDefaultAsync(x => x.MobileBusinessNavigation.BusinessOrganizationNavigation.Uuid == party);

                    var poAddress = await context.MobileBusiness
                        .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation)
                        .Include(x => x.OwnerFkNavigation).ThenInclude(x => x.PrimaryContactMechanismFkNavigation).ThenInclude(x => x.PostOfficeAddress)
                        .FirstOrDefaultAsync(x => x.MobileBusinessNavigation.BusinessOrganizationNavigation.Uuid == party);

                    var bsEmail = await context.MobileBusiness
                        .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation)
                        .Include(x => x.OwnerFkNavigation).ThenInclude(x => x.PrimaryContactMechanismFkNavigation).ThenInclude(x => x.EmailAddress)
                        .FirstOrDefaultAsync(x => x.MobileBusinessNavigation.BusinessOrganizationNavigation.Uuid == party);

                    if (contMech.OwnerFkNavigation.PrimaryContactMechanismFkNavigation == null)
                    {
                        var cm = new ContactMechanism()
                        {
                            Uuid = Guid.NewGuid().ToString()
                        };

                        await context.ContactMechanism.AddAsync(cm);

                        await context.SaveChangesAsync();

                        if (person == null)
                        {

                            var p = new Person()
                            {
                                PrimaryContactMechanismFk = cm.ContactMechanismId,
                                PlatformUserName = businessDto.OwnerFkNavigation.PlatformUserName,
                                FullName = businessDto.OwnerFkNavigation.FullName
                            };

                            await context.Person.AddAsync(p);
                        }
                        else
                        {
                            person.OwnerFkNavigation.PlatformUserName = businessDto.OwnerFkNavigation.PlatformUserName;
                            person.OwnerFkNavigation.FullName = businessDto.OwnerFkNavigation.FullName;
                            context.MobileBusiness.Update(person);
                        }

                        await context.SaveChangesAsync();

                        //now that we have contact mechanism relationship, we can create the post office address
                        var poa = new PostOfficeAddress
                        {
                            PostOfficeAddressId = cm.ContactMechanismId,
                            AddressLine1 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine1,
                            AddressLine2 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine2,
                            AddressLine3 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine3,
                            City = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.City,
                            StatePostalCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.StatePostalCode,
                            ZipCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.ZipCode
                        };

                        await context.PostOfficeAddress.AddAsync(poa);

                        await context.SaveChangesAsync();

                        var email = await context.EmailAddress.FirstOrDefaultAsync(x => x.EmailAddressId == cm.ContactMechanismId);

                        if (email != null)
                        {
                            email.Email = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.Email;
                            email.EmailTypeCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.EmailTypeCode;

                            context.EmailAddress.Update(email);
                        }
                        else
                        {
                            //create Email Address
                            var e = new EmailAddress()
                            {
                                EmailAddressId = cm.ContactMechanismId,
                                Email = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.Email,
                                EmailTypeCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.EmailTypeCode
                            };

                            await context.EmailAddress.AddAsync(e);
                        }
                    }
                    else //If there's an existing contact mechanism associated with the provided mobile business id
                    {
                        if (person == null)
                        {
                            var p = new Person()
                            {
                                PrimaryContactMechanismFk = contMech.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.ContactMechanismId,
                                PlatformUserName = businessDto.OwnerFkNavigation.PlatformUserName,
                                FullName = businessDto.OwnerFkNavigation.FullName
                            };

                            await context.Person.AddAsync(p);
                        }
                        else
                        {
                            person.OwnerFkNavigation.PlatformUserName = businessDto.OwnerFkNavigation.PlatformUserName;
                            person.OwnerFkNavigation.FullName = businessDto.OwnerFkNavigation.FullName;

                            context.MobileBusiness.Update(person);
                        }

                        if (poAddress.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress != null)
                        {
                            poAddress.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine1 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine1;
                            poAddress.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine2 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine2;
                            poAddress.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine3 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine3;
                            poAddress.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.City = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.City;
                            poAddress.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.StatePostalCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.StatePostalCode;
                            poAddress.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.ZipCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.ZipCode;

                            context.MobileBusiness.Update(poAddress);
                        }
                        else
                        {
                            var poa = new PostOfficeAddress
                            {
                                PostOfficeAddressId = contMech.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.ContactMechanismId,
                                AddressLine1 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine1,
                                AddressLine2 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine2,
                                AddressLine3 = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.AddressLine3,
                                City = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.City,
                                StatePostalCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.StatePostalCode,
                                ZipCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.PostOfficeAddress.ZipCode
                            };

                            await context.PostOfficeAddress.AddAsync(poa);
                        }

                        if (bsEmail.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress != null)
                        {
                            bsEmail.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.Email = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.Email;
                            bsEmail.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.EmailTypeCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.EmailTypeCode;

                            context.MobileBusiness.Update(bsEmail);
                        }
                        else
                        {
                            //create Email Address
                            var e = new EmailAddress()
                            {
                                EmailAddressId = contMech.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.ContactMechanismId,
                                Email = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.Email,
                                EmailTypeCode = businessDto.OwnerFkNavigation.PrimaryContactMechanismFkNavigation.EmailAddress.EmailTypeCode
                            };

                            await context.EmailAddress.AddAsync(e);
                        }
                    }

                    //Save changes
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                }

                response.Data = businessDto;

                //Success
                response.Success = true;
                response.Message = $"Party ID {party} updated.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<MobileBusinessDto>> AddBankAccountInfo(MobileBusinessDto businessDto)
        {
            var response = new ServiceResponse<MobileBusinessDto>();

            try
            {
                //Validation
                if (businessDto == null)
                {
                    throw new ArgumentNullException(nameof(businessDto));
                }


                using (var dbContextTransaction = context.Database.BeginTransaction())
                {

                    var data = await context.MobileBusiness.Include(x => x.OwnerFkNavigation)
                      .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation).ThenInclude(x => x.PartyBankAccount)
                      .FirstOrDefaultAsync(x => x.MobileBusinessId == businessDto.MobileBusinessId);


                    if (data != null)
                    {

                        data.MobileBusinessNavigation.OrganizationName = businessDto.MobileBusinessNavigation.OrganizationName;
                        data.MobileBusinessNavigation.Ein = businessDto.MobileBusinessNavigation.Ein;
                        data.MobileBusinessNavigation.LastUpdateTimestamp = DateTime.Now;

                        var baDto = businessDto.OwnerFkNavigation.PersonNavigation.PartyBankAccount.FirstOrDefault(x => x.PartyFk == businessDto.OwnerFkNavigation.PersonNavigation.PartyId);

                        if (baDto != null)
                        {
                            //Create a new bank account record
                            var bankAccount = new PartyBankAccount
                            {
                                PartyFk = businessDto.OwnerFkNavigation.PersonNavigation.PartyId,
                                RoutingNumber = baDto.RoutingNumber,
                                AccountNumber = baDto.AccountNumber,
                                LastUpdateTimestamp = DateTime.Now
                            };


                            await context.PartyBankAccount.AddAsync(bankAccount);

                        }

                    }
                    else
                    {
                        throw new Exception($"Mobile Business {businessDto.MobileBusinessId} does not exist.");
                    }

                    //Save changes
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                }

                response.Data = businessDto;

                //Success
                response.Success = true;
                response.Message = $"MobileBusinessDto ID {businessDto.MobileBusinessId} updated.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public async Task<ServiceResponse<PartyBankAccountDto>> GetBankAccountInfo(string partyId)
        {
            //create response
            var response = new ServiceResponse<PartyBankAccountDto>();

            var party = await context.Party
                .Include(x => x.PartyBankAccount)
                .FirstOrDefaultAsync(x => x.Uuid == partyId);

            var acct = party.PartyBankAccount.OrderByDescending(x => x.LastUpdateTimestamp).FirstOrDefault();

            //map to dto
            response.Data = new PartyBankAccountDto()
            {
                PartyBankAccountId = acct.PartyBankAccountId,
                PartyFk = acct.PartyFk,
                AccountNumber = acct.AccountNumber,
                RoutingNumber = acct.RoutingNumber
            };

            return response;
        }

        public async Task<ServiceResponse<string>> UpdateBankAccountInfo(string PartyUuid, PartyBankAccountUpdateDto businessDto)
        {
            var response = new ServiceResponse<string>();

            try
            {
                //Validation
                if (businessDto == null)
                {
                    throw new ArgumentNullException(nameof(businessDto));
                }

                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    var data = await context.MobileBusiness.Include(x => x.OwnerFkNavigation).Include(x => x.MobileBusinessPlatformSupportedFormOfPayment)
                      .Include(x => x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation).ThenInclude(x => x.PartyBankAccount)
                      .FirstOrDefaultAsync(x => x.MobileBusinessNavigation.BusinessOrganizationNavigation.Uuid.Equals(PartyUuid));

                    if (data != null)
                    {
                        data.MobileBusinessNavigation.Ein = businessDto.Ein;
                        data.MobileBusinessNavigation.LastUpdateTimestamp = DateTime.UtcNow;

                        //Update existing bank account info
                        var bankAcct = data.MobileBusinessNavigation.BusinessOrganizationNavigation.PartyBankAccount.OrderByDescending(x => x.LastUpdateTimestamp).FirstOrDefault();

                        if (bankAcct == null)
                        {
                            bankAcct = new PartyBankAccount();
                            bankAcct.PartyFk = data.MobileBusinessNavigation.BusinessOrganizationNavigation.PartyId;
                        }

                        bankAcct.RoutingNumber = businessDto.PartyBankAccount.RoutingNumber;
                        bankAcct.AccountNumber = businessDto.PartyBankAccount.AccountNumber;
                        bankAcct.LastUpdateTimestamp = DateTime.UtcNow;

                        context.PartyBankAccount.Update(bankAcct);

                        
                        //Check if list is not empty

                        if (businessDto.MobileBusinessPlatformSupportedFormOfPayment != null)
                        {
                            var formsOfPayment = data.MobileBusinessPlatformSupportedFormOfPayment.ToList();

                            //If there's already an existing forms of payment list we remove it 
                            //so we can update the table from scratch with the new collection

                            if (formsOfPayment != null)
                            {   
                                context.MobileBusinessPlatformSupportedFormOfPayment.RemoveRange(formsOfPayment);
                                await context.SaveChangesAsync();
                            }

                            foreach (var fp in businessDto.MobileBusinessPlatformSupportedFormOfPayment)
                            {
                                var formOfPayment = new MobileBusinessPlatformSupportedFormOfPayment()
                                {
                                    MobileBusinessFk = data.MobileBusinessId,
                                    PlatformSupportedFormOfPaymentFk = fp.PlatformSupportedFormOfPaymentFk,
                                    LastUpdateTimestamp = DateTime.UtcNow
                                };

                                await context.MobileBusinessPlatformSupportedFormOfPayment.AddAsync(formOfPayment);
                            }

                            await context.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        throw new Exception($"Mobile Business with Party Id {PartyUuid} does not exist.");
                    }

                    //update timestamp
                    data.LastUpdateTimestamp = DateTime.UtcNow;

                    //Save changes
                    await context.SaveChangesAsync();
                    await dbContextTransaction.CommitAsync();
                }

                response.Data = "";

                //Success
                response.Success = true;
                response.Message = $"Mobile business with Party Id {PartyUuid} updated.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        public Task<ServiceResponse<MobileBusinessDto>> CreateBusiness(MobileBusinessCreateDto business)
        {
            throw new NotImplementedException();
        }
    }
}
