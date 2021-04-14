using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class BusinessLocation
    {
        public BusinessLocation()
        {
            BusinessLocationContactMechanism = new HashSet<BusinessLocationContactMechanism>();
            BusinessLocationInventory = new HashSet<BusinessLocationInventory>();
            BusinessLocationManager = new HashSet<BusinessLocationManager>();
            BusinessLocationService = new HashSet<BusinessLocationService>();
            BusinessLocationServiceBay = new HashSet<BusinessLocationServiceBay>();
            BusinessLocationStaff = new HashSet<BusinessLocationStaff>();
            Cart = new HashSet<Cart>();
            CartProductServiceDetail = new HashSet<CartProductServiceDetail>();
            MobileBusinessEmployeeLocationFillin = new HashSet<MobileBusinessEmployeeLocationFillin>();
            RetailCustomerServiceLocationPreference = new HashSet<RetailCustomerServiceLocationPreference>();
        }

        public long BusinessLocationId { get; set; }
        public long MobileBusinessFk { get; set; }
        public long? AddressFk { get; set; }
        public string LocationName { get; set; }
        public string HeadquartersFlag { get; set; }
        public int? GreenwichOffset { get; set; }
        public decimal? TradeRadiusInMiles { get; set; }
        public DateTime LocationStartDate { get; set; }
        public DateTime? LocationEndDate { get; set; }
        public string RetailWarehouseIndicator { get; set; }
        public int? ServiceCapacity { get; set; }
        public string ServiceCapacityTreatmentIndicator { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public byte[] RecordVersion { get; set; }

        public virtual PostOfficeAddress AddressFkNavigation { get; set; }
        public virtual MobileBusiness MobileBusinessFkNavigation { get; set; }
        public virtual BusinessLocationHoursOfOperation BusinessLocationHoursOfOperation { get; set; }
        public virtual ICollection<BusinessLocationContactMechanism> BusinessLocationContactMechanism { get; set; }
        public virtual ICollection<BusinessLocationInventory> BusinessLocationInventory { get; set; }
        public virtual ICollection<BusinessLocationManager> BusinessLocationManager { get; set; }
        public virtual ICollection<BusinessLocationService> BusinessLocationService { get; set; }
        public virtual ICollection<BusinessLocationServiceBay> BusinessLocationServiceBay { get; set; }
        public virtual ICollection<BusinessLocationStaff> BusinessLocationStaff { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<CartProductServiceDetail> CartProductServiceDetail { get; set; }
        public virtual ICollection<MobileBusinessEmployeeLocationFillin> MobileBusinessEmployeeLocationFillin { get; set; }
        public virtual ICollection<RetailCustomerServiceLocationPreference> RetailCustomerServiceLocationPreference { get; set; }
    }
}
