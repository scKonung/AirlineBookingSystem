using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace AirlineBookingSystem.Server.Entities
{
    public class Airport
    {
        public int AirportId { get; set; }

        public string Name { get; set; }
        public AirportType AirportType { get; set; }

        public string IataCode { get; set; }

        public string IcaoCode { get; set; }
        public string FaaCode { get; set; }

        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public DateTime OpenDate { get; set; }

        public string ContactEmail { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public int MaxPlanesOnGround { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Airplane> Airplanes { get; set; }
    }

    public enum AirportType
    {
        Commercial,
        SecondaryCommercial,
        Loading,
        Relay,
        GeneralAviation,
        Domestic,
        Regional,
        Local,
        Unclassified
    }
}
