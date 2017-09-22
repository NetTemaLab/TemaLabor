using System.Collections.Generic;

namespace DanubiusInfo.B4USApi.DTO
{
    public class ServiceAndLocationsDTO
    {
        public ServiceAndLocationsDTO()
        {
            this.Locations = new List<LocationDTO>();
            this.Services = new List<ServiceDTO>();
        }

        public ICollection<LocationDTO> Locations { get; set; }
        public ICollection<ServiceDTO> Services { get; set; }
    }
}
