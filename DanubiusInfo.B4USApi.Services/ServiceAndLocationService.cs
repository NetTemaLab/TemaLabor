using DanubiusInfo.B4USApi.Data.Model;
using DanubiusInfo.B4USApi.DTO;
using DanubiusInfo.B4USApi.Providers.Interfaces;
using DanubiusInfo.B4USApi.Services.Interfaces;
using DanubiusInfo.B4USApi.UOW;
using System.Linq;

namespace DanubiusInfo.B4USApi.Services
{
    public class ServiceAndLocationService : IServiceAndLocationService
    {
        private IServiceProvider serviceProvider;
        private ILocationProvider locationProvider;
        private IUnitOfWork unitOfWork;
        public ServiceAndLocationService(
            IServiceProvider serviceProvider, 
            ILocationProvider locationProvider,
            IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.serviceProvider = serviceProvider;
            this.locationProvider = locationProvider;
        }

        public bool AddServiceAndLocation(LocationDTO location, ServiceDTO service)
        {
            var serviceEntity = new Service
            {
                Name = location.Name
            };

            var locationEntity = new Location
            {
                Name = service.Name
            };

            this.serviceProvider.Add(serviceEntity);
            this.locationProvider.Add(locationEntity);

            var affectedRows = this.unitOfWork.Commit();

            return affectedRows > 0;
        }

        public ServicesAndLocationsDTO GetServicesAndLocations()
        {
            var result = new ServicesAndLocationsDTO();
            var services = this.serviceProvider.GetAll();
            var locations = this.locationProvider.GetAll();

            foreach(var service in services)
            {
                result.Services.Add(new ServiceDTO
                {
                    Id = service.Id
                });
            }

            foreach(var location in locations)
            {
                result.Locations.Add(new LocationDTO
                {
                    Id = location.Id
                });
            }

            return result;
        }
    }
}
