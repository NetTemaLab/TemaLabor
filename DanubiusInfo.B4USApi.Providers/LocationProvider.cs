using DanubiusInfo.B4USApi.Providers.Interfaces;
using DanubiusInfo.B4USApi.Data.Model;
using System.Data.Entity;
using System.Linq;
using DanubiusInfo.B4USApi.Data;

namespace DanubiusInfo.B4USApi.Providers
{
    public class LocationProvider : GenericProvider<Location>, ILocationProvider
    {
        public LocationProvider(B4USContext context)
            : base(context) { }

        public Location Get(int id)
        {
            return this.dbset.FirstOrDefault(location => location.Id == id);
        }
    }
}
