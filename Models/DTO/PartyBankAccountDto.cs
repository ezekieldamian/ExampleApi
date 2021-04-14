using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Models.DTO
{
        public partial class PartyBankAccountDto
        {
            public long PartyBankAccountId { get; set; }
            public long PartyFk { get; set; }
            public string RoutingNumber { get; set; }
            public string AccountNumber { get; set; }
        }
}
