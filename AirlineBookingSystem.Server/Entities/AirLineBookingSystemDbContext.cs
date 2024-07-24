using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

namespace AirlineBookingSystem.Server.Entities
{
    public class AirLineBookingSystemDbContext : DbContext
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=AirLineBookingSystemDb;Trusted_Connection=True;";
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Facility> Facilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>()
                .Property(a => a.AirportId)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
