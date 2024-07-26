using AirlineBookingSystem.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirlineBookingSystem.Server.Database
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Coordinate> Coordinates { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Facility> Facilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AirportConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConifugration());
            //TODO for airplanes
            throw new NotImplementedException();
        }

    }
}
