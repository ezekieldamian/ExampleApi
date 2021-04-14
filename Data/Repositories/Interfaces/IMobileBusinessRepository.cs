using Empr.CoreServicesApi.Data.Models;
using Empr.CoreServicesApi.Models;
using Empr.CoreServicesApi.Models.DTO;
using Empr.CoreServicesApi.Models.DTO.Create;
using Empr.CoreServicesApi.Models.DTO.Request;
using Empr.CoreServicesApi.Models.DTO.Response;
using Empr.CoreServicesApi.Models.DTO.Update;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Data.Repositories.Interfaces
{
    public interface IMobileBusinessRepository
    {
        Task<ServiceResponse<IEnumerable<MobileBusinessDto>>> GetAllBusinesses();
        Task<ServiceResponse<MobileBusinessDto>> GetBusinessById(long id);
        Task<ServiceResponse<MobileBusinessDto>> CreateBusiness(MobileBusinessCreateDto business);
        Task<ServiceResponse<MobileBusinessDto>> UpdateBusiness(MobileBusinessDto business);
        Task<ServiceResponse<IEnumerable<MobileBusinessDto>>> DeleteBusiness(long id);
        Task<ServiceResponse<IEnumerable<BusinessCategoryDto>>> GetAllBusinessCategories();
        ServiceResponse<MobileBusinessDto> AddMobileBusiness(MobileBusinessCreateDto business);
        Task<ServiceResponse<MobileBusinessDto>> UpdateBusinessCategory(MobileBusinessDto business);
        Task<ServiceResponse<MobileBusinessDto>> AddBusinessCategory(MobileBusinessDto business, OfferType offerType);
        ServiceResponse<MobileBusinessDto> CheckBusinessName(BusinessOrganizationCreateDto business);
        Task<ServiceResponse<IEnumerable<CountryDto>>> GetAllCountries();
        Task<ServiceResponse<IEnumerable<StateOrProvinceDto>>> GetAllStates(int countryId);
        Task<ServiceResponse<MobileBusinessRioritiesResponseDto>> AddBusinessPriority(BusinessPrioritiesRequestDto business, ActorType participantType);
        Task<ServiceResponse<IEnumerable<PlatformObjectiveDto>>> GetBusinessPriorities(ActorType participantType);
        Task<ServiceResponse<MobileBusinessDto>> AddAddressAndServiceAreaData(MobileAddressAndServiceAreaDto data);
        Task<ServiceResponse<MobileBusinessUpdateLogoResponeDto>> SaveImage(HttpRequest httpRequest);
        Task<IEnumerable<PlatformStoreThemeDto>> GetPlatformStoreThemes();
        Task<IEnumerable<PlatformScreensMainColorDto>> GetPlatformScreenColors();
        Task<ServiceResponse<MobileBusinessDto>> SetPlatformScreenColors(MobileBusinessDto data);
        Task<ServiceResponse<MobileBusinessDto>> SetPlatformStoreThemes(MobileBusinessDto data);
        Task<ServiceResponse<IEnumerable<CountryCodeDto>>> GetCountryCodes();
        Task<ServiceResponse<IEnumerable<ProductDto>>> AddGoods(AddProductsRequestDto data);
        Task<ServiceResponse<IEnumerable<ProductDto>>> AddServices(AddProductsRequestDto data);
        Task<ServiceResponse<PersonDto>> GetContactDetails();
        Task<ServiceResponse<PersonAsUserDto>> CreatePersonAsPlatformUser(PersonAsUserDto user, ActorType actorType);
        Task<ServiceResponse<MobileBusinessDto>> EditContactDetails(MobileBusinessDto user);
        Task<ServiceResponse<MobileBusinessDto>> AddBankAccountInfo(MobileBusinessDto userDto);
        Task<ServiceResponse<PartyBankAccountDto>> GetBankAccountInfo(string partyId);
        Task<ServiceResponse<string>> UpdateBankAccountInfo(string partyUuid, PartyBankAccountUpdateDto userDto);
        Task<ServiceResponse<MobileBusinessDto>> CreateBusinessForExistingUser(MobileBusinessCreateDto business);
    }
}
