﻿namespace AirlineBookingSystem.Server.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }

        public virtual Airport Airport { get; set; }

    }
}
