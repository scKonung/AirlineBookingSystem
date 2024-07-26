namespace AirlineBookingSystem.Server.Entities
{
    public class Airplane
    {
        public int AirplaneId { get; set; }
        public string RegistrationNumber { get; set; }

        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int SeatingCapacity { get; set; }
        public DateTime ManufacturedData { get; set; }

        public bool IsAvailable { get; set; }
        public bool IsDeleted { get; set; }


        public int HomeAirportId { get; set; }
        public virtual Airport HomeAirport { get; set; }

        public int CurrentAirportId { get; set; }
        public virtual Airport CurrentAirport { get; set; }
    }
}
