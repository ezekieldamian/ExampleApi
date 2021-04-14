using System;

namespace Empr.CoreServicesApi.Models.DTO.Create
{
    public class BusinessOrganizationCreateDto
    {
        public string OrganizationName { get; set; }
        public string NonProfitFlag { get; set; }
 
        //public virtual PartyCreateDto BusinessOrganizationNavigation { get; set; }
    }
}