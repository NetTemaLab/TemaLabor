using DanubiusInfo.B4USApi.Data.Model;
using DanubiusInfo.B4USApi.Providers.Interfaces;

namespace DanubiusInfo.B4USApi.Providers
{
    public interface IReservationProvider : IGenericProvider<Reservation>
    {
        Reservation Get(int id);
    }
}