using DanubiusInfo.B4USApi.Data.Model;

namespace DanubiusInfo.B4USApi.Providers.Interfaces
{
    public interface IServiceProvider : IGenericProvider<Service>
    {
        Service Get(int id);
    }
}
