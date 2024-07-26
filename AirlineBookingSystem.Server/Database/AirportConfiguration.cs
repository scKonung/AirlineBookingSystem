using AirlineBookingSystem.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirlineBookingSystem.Server.Database
{
    public class AirportConfiguration : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.ToTable("Airports");

            builder.HasKey(a => a.AirportId);

            builder
                .Property(a => a.Name)
                .IsRequired();

            builder
                .Property(a => a.IcaoCode) 
                .IsRequired()
                .HasMaxLength(4);

            builder
                .Property(a => a.CreatedTime)
                .IsRequired();


            builder
                .Property(a => a.OpenDate)
                .IsRequired();

            builder
                .Property(a => a.IsActive)
                .IsRequired();

            builder
                .Property(a => a.IsDeleted)
                .IsRequired();

        }
    }
}
