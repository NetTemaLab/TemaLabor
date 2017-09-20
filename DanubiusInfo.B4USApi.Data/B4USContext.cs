using DanubiusInfo.B4USApi.Data.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.MapLocation(modelBuilder.Entity<Location>());

            base.OnModelCreating(modelBuilder);
        }

        private B4USContext MapLocation(EntityTypeConfiguration<Location> configuration)
        {
            configuration
                .HasMany(location => location.Services)
                .WithMany(service => service.Locations)
                .Map(config =>
                {
                    config.ToTable("servicetoloc");
                    config.MapLeftKey("LocID");
                    config.MapRightKey("ServiceId");
                });
            return this;
        }
    }
}
