using AutoMapper;
using Empr.CoreServicesApi.Data.Models;
using Empr.CoreServicesApi.Models;
using Empr.CoreServicesApi.Models.DTO;
using Empr.CoreServicesApi.Models.DTO.Create;
using Empr.CoreServicesApi.Models.DTO.Update;

namespace Empr.CoreServicesApi.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //update models
            CreateMap<MobileBusiness, MobileBusiness>();
            CreateMap<BusinessOrganization, BusinessOrganization>();
            CreateMap<Party, Party>();
            CreateMap<TaxItemType, TaxItemType>();

            //map new models
            CreateMap<MobileBusiness, MobileBusinessDto>();
            CreateMap<MobileBusinessDto, MobileBusiness>();
            CreateMap<MobileBusinessDto, MobileBusinessUpdateDto>();
            CreateMap<MobileBusinessUpdateDto, MobileBusiness>();
            CreateMap<MobileBusinessCreateDto, MobileBusiness>();

            CreateMap<BusinessOrganization, BusinessOrganizationDto>();
            CreateMap<BusinessOrganizationDto, BusinessOrganizationUpdateDto>();
            CreateMap<BusinessOrganizationUpdateDto, BusinessOrganization>();
            CreateMap<BusinessOrganizationDto, BusinessOrganization>();
            CreateMap<BusinessOrganizationCreateDto, BusinessOrganization>();

            CreateMap<TaxItemType, TaxItemTypeDto>();
            CreateMap<TaxItemTypeDto, TaxItemType>();
            CreateMap<TaxItemTypeDto, TaxItemTypeUpdateDto>();
            CreateMap<TaxItemTypeUpdateDto, TaxItemType>();
            CreateMap<TaxItemTypeCreateDto, TaxItemType>();

            CreateMap<Party, PartyDto>();
            CreateMap<PartyDto, Party>();
            CreateMap<PartyDto, PartyUpdateDto>();
            CreateMap<PartyUpdateDto, Party>();
            CreateMap<PartyCreateDto, Party>();

            CreateMap<MobileBusinessBusinessCategory, MobileBusinessBusinessCategoryDto>();
            CreateMap<MobileBusinessBusinessCategoryDto, MobileBusinessBusinessCategory>();
            CreateMap<BusinessCategory, BusinessCategoryDto>();
            CreateMap<BusinessCategoryDto, BusinessCategory>();

            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();

            CreateMap<StateOrProvince, StateOrProvinceDto>();
            CreateMap<StateOrProvinceDto, StateOrProvince>();

            //CreateMap<PlatformMobileBusinessMonthlyVolumeBracket, PlatformMobileBusinessMonthlyVolumeBracketDto>();
            //CreateMap<PlatformMobileBusinessMonthlyVolumeBracketDto, PlatformMobileBusinessMonthlyVolumeBracket>();
            CreateMap<PlatformMobileBusinessMonthlyVolumeBracketDto, PlatformMobileBusinessMonthlyVolumeBracketDto>();

            CreateMap<PlatformScreensMainColor, PlatformScreensMainColorDto>();
            CreateMap<PlatformScreensMainColorDto, PlatformScreensMainColor>();

            CreateMap<PlatformStoreTheme, PlatformStoreThemeDto>();
            CreateMap<PlatformStoreThemeDto, PlatformStoreTheme>();

            //CreateMap<ServiceAreaBracket, ServiceAreaBracketDto>();
            //CreateMap<ServiceAreaBracketDto, ServiceAreaBracket>();

            //CreateMap<TransactionsPerMonthBracket, TransactionsPerMonthBracketDto>();
            //CreateMap<TransactionsPerMonthBracketDto, TransactionsPerMonthBracket>();

            //CreateMap<TransactionSizeBracket, TransactionSizeBracketDto>();
            //CreateMap<TransactionSizeBracketDto, TransactionSizeBracket>();
            //CreateMap<TransactionSizeBracketDto, TransactionSizeBracketDto>();

            CreateMap<PlatformObjective, PlatformObjectiveDto>();
            CreateMap<PlatformObjectiveDto, PlatformObjective>();
            CreateMap<PostOfficeAddress, PostOfficeAddressDto>();
            CreateMap<PostOfficeAddressDto, PostOfficeAddress>();

            CreateMap<ContactMechanism, ContactMechanismDto>();
            CreateMap<ContactMechanismDto, ContactMechanism>();

            CreateMap<BusinessLocation, BusinessLocationDto>();
            CreateMap<BusinessLocationDto, BusinessLocation>();

            CreateMap<MobileBusiness, MobileBusinessUpdateSalesReponseDto>();

            CreateMap<PlatformParticipantType, PlatformParticipantTypeDto>();
            CreateMap<PlatformParticipantTypeDto, PlatformParticipantType>();

            CreateMap<PartyPlatformObjectivePriority, PartyPlatformObjectivePriorityDto>();
            CreateMap<PartyPlatformObjectivePriorityDto, PartyPlatformObjectivePriority>();

            CreateMap<MobileBusiness, MobileBusinessUpdateLogoResponeDto>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Good, GoodDto>();
            CreateMap<GoodDto, Good>();

            CreateMap<ProfessionalService, ProfessionalServiceDto>();
            CreateMap<ProfessionalServiceDto, ProfessionalService>();

            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
        }
    }
}
