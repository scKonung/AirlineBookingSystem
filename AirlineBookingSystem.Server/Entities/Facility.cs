namespace AirlineBookingSystem.Server.Entities
{
    public abstract class Facility
    {
        public int FacilityId { get; set; }
        public string Name { get; set; }
        public FacilityType Type { get; set; }
        public int Capacity { get; set; }

        public int AirportId { get; set; }
        public virtual Airport Airport { get; set; }
    }


    public enum FacilityType
    {
        Gate,
        Runway,
        Terminal,
        Maintenance,
        Parking,
        Lounge,
        Security,
        Customs,
        Other
    }
}