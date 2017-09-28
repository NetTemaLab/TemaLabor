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
        public DbSet<Reservation> Reservation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.MapLocation(modelBuilder.Entity<Location>());
            this.MapReservation(modelBuilder.Entity<Reservation>());

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

        private B4USContext MapReservation(EntityTypeConfiguration<Reservation> configuration)
        {
            configuration
                .HasRequired(reservation => reservation.Location)
                .WithMany(location => location.Reservation)
                .Map(config =>
                {
                    config.MapKey("Location");
                });
            return this;
        }

        private B4USContext MapSchedule(EntityTypeConfiguration<Schedule> configuration)
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
