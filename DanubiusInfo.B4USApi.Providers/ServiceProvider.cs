using DanubiusInfo.B4USApi.Data;
using DanubiusInfo.B4USApi.Data.Model;
using DanubiusInfo.B4USApi.Providers.Interfaces;
using System.Linq;

namespace DanubiusInfo.B4USApi.Providers
{
    public class ServiceProvider : GenericProvider<Service>, IServiceProvider
    {
        public ServiceProvider(B4USContext context)
            : base(context) { }

        public Service Get(int id)
        {
            return this.dbset.FirstOrDefault(p => p.Id == id);
        }
    }
}
