using DanubiusInfo.B4USApi.Data.Model;
using System.Data.Entity;

namespace DanubiusInfo.B4USApi.Data
{
    public class B4USContext : DbContext
    {
        public B4USContext()
            : base(nameOrConnectionString: "B4USContext")
        { }

        public B4USContext(string connectionstring)
            : base(connectionstring) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
