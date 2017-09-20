using DanubiusInfo.B4USApi.Data.Model;

namespace DanubiusInfo.B4USApi.Providers.Interfaces
{
    public interface ILocationProvider : IGenericProvider<Location>
    {
        Location Get(int id);
    }
}
