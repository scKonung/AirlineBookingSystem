using Microsoft.EntityFrameworkCore;
using AirlineBookingSystem.Server.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirlineBookingSystem.Server.Database
{
    public class AddressConifugration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable(nameof(Address));

            builder.
                Property(a => a.Country)
                .IsRequired();

            builder
                .Property(a => a.City)
                .IsRequired();
        }
    }
}
