using System.Numerics;

namespace AirlineBookingSystem.Server.Entities
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public string IataCode { get; set; }
        public string IcaoCode { get; set; }
        public string ContactEmail { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public int MaxPlanesOnGround { get; set; }
        public int AvailableGates { get; set; }
        public int TotalRunways { get; set; }
        public int MaxTaxiwayCapacity { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Plane> Planes { get; set; }
    }
}
