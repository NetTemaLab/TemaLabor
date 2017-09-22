using DanubiusInfo.B4USApi.Data.Model;
using DanubiusInfo.B4USApi.DTO;
using DanubiusInfo.B4USApi.Providers;
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
        private IReservationProvider reservationProvider;
        public ServiceAndLocationService(
            IServiceProvider serviceProvider, 
            ILocationProvider locationProvider,
            IUnitOfWork unitOfWork, IReservationProvider reservationProvider)
        {
            this.unitOfWork = unitOfWork;
            this.serviceProvider = serviceProvider;
            this.locationProvider = locationProvider;
            this.reservationProvider = reservationProvider;
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

        public ReservationAndLocationDTO GetServicesAndLocations()
        {
            var reservation = this.reservationProvider.Get(1);
            var reservationDTO = new ReservationAndLocationDTO { Id = reservation.Id, LocationDTO = new LocationDTO { Id = reservation.Location.Id, Name = reservation.Location.Name } };
            return reservationDTO;
        }
    }
}
