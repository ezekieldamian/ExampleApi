using Empr.CoreServicesApi.Data;
using Empr.CoreServicesApi.Data.Repositories;
using Empr.CoreServicesApi.Models.DTO;
using System;
using System.Linq;

namespace Empr.CoreServicesApi.Utilities
{
    public class Validation
    {
        //public static void CheckActorType(MobileBusinessCreateDto business)
        //{
        //    //make sure actor type is valid
        //    //todo: create a validation class
        //    if (!typeof(ActorType).GetAllDescriptions<ActorType>().Contains(business.ActorType))
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(business.ActorType));
        //    }
        //}

        public static void CheckUserIdExists(ReVyvvDataContext context, int id)
        {
            if (context.PersonAsUser.FirstOrDefault(x => x.PersonAsUserId == id) != null)
            {
                throw new Exception($"Person id '{id}' already exists.");
            }
        }

        public static void CheckBusinessIdExists(ReVyvvDataContext context, int id)
        {
            if (context.MobileBusiness.FirstOrDefault(x => x.MobileBusinessId == id) == null)
            {
                throw new Exception($"Business id {id} doesn't exist.");
            }
        }

        public static void CheckPersonIdExists(ReVyvvDataContext context, int id)
        {
            if (context.Person.FirstOrDefault(x => x.PersonId == id) == null)
            {
                throw new Exception($"Person id '{id}' doesn't exist.");
            }
        }

        public static void CheckMobileBusinessFkExists(ReVyvvDataContext context, int id)
        {
            if (context.Product.FirstOrDefault(x => x.ProductId == id) == null)
            {
                throw new Exception($"Product with MobileBusinessFk id '{id}' already exists.");
            }
        }

        //public static void CheckMonthlyVolumeBracketIdExists(ReVyvvDataContext context, int id)
        //{
        //    if (context.PlatformMobileBusinessMonthlyVolumeBracket.FirstOrDefault(x => x.PlatformMobileBusinessMonthlyVolumeBracketId == id) == null)
        //    {
        //        throw new Exception($"Monthly Volume Bracket id {id} doesn't exist.");
        //    }
        //}

        public static void CheckOrganizationNameExists(ReVyvvDataContext context, string organizationName)
        {
            if (string.IsNullOrEmpty(organizationName))
            {
                return;
            }

            //check if name exists
            //make sure business name doesn't exist already.
            if (context.MobileBusiness.FirstOrDefault(x => x.MobileBusinessNavigation.OrganizationName.Equals(organizationName)) != null)
            {
                throw new Ex_O_02($"Business Name '{organizationName}' already exists.");
            }
        }

        public static void CheckOrganizationNameIsNotBlank(string organizationName)
        {
            //make sure organization name is not blank
            if (string.IsNullOrEmpty(organizationName))
            {
                throw new Ex_O_01("Organization Name cannot be empty.");
            }
        }

        public static void CheckAtLeastOneCategory(MobileBusinessDto business)
        {
            //make sure at least one bc was provided
            if (business.MobileBusinessBusinessCategory == null || business.MobileBusinessBusinessCategory.Count == 0)
            {
                throw new Ex_O_03("Business category not found.");
            }
        }
    }
}