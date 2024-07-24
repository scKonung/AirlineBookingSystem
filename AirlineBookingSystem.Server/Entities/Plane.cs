namespace AirlineBookingSystem.Server.Entities
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int SeatingCapacity { get; set; }
        public string RegistrationNumber { get; set; }
        public int YearOfManufacture { get; set; }

        public int HomeAirportId { get; set; }
        public virtual Airport HomeAirport { get; set; }

        public int CurrentAirportId { get; set; }
        public virtual Airport CurrentAirport { get; set; }
    }
}
