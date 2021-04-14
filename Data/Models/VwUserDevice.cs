using System;
using System.Collections.Generic;

namespace Empr.CoreServicesApi.Data.Models
{
    public partial class VwUserDevice
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string SmartphoneSerialNumber { get; set; }
        public string SmartphoneDeviceType { get; set; }
        public string SmartphoneModel { get; set; }
        public string SmartphoneModelNumber { get; set; }
        public string SmartphoneManufacturer { get; set; }
        public string SmartphoneOs { get; set; }
        public string SmartphoneOsVersion { get; set; }
        public string TabletSerialNumber { get; set; }
        public string TabletDeviceType { get; set; }
        public string TabletModel { get; set; }
        public string TabletModelNumber { get; set; }
        public string TabletManufacturer { get; set; }
        public string TabletOs { get; set; }
        public string TabletOsVersion { get; set; }
    }
}
