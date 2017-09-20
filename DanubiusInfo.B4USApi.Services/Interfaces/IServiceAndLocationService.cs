using DanubiusInfo.B4USApi.DTO;

namespace DanubiusInfo.B4USApi.Services.Interfaces
{
    public interface IServiceAndLocationService
    {
        ServicesAndLocationsDTO GetServicesAndLocations();
        bool AddServiceAndLocation(LocationDTO location, ServiceDTO service);
    }
}
