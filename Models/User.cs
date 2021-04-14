using Empr.CoreServicesApi.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Models
{
    ///this is a simple user class used for authorization.
    ///this will be expanded upon once Authorization is fully implemented
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        //public List<MobileBusiness> Businesses { get; set; }

        [Required]
        public string Role { get; set; }

    }
}
