namespace AirlineBookingSystem.Server.Entities
{
    public class Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
