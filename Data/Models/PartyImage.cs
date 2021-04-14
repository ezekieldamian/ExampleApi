using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class PartyImage
    {
        public long PartyImageId { get; set; }
        public long PartyFk { get; set; }
        public long PlatformParticipantTypeFk { get; set; }
        public string ImageDescription { get; set; }
        public byte[] SavedImage { get; set; }

        public virtual Party PartyFkNavigation { get; set; }
        public virtual PlatformParticipantType PlatformParticipantTypeFkNavigation { get; set; }
    }
}
