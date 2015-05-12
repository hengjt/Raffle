namespace Raffle.Domain
{
    public class Address
    {
        public int UserId { get; set; }

        public string StreetName { get; set; }

        public int Number { get; set; }

        public string Complement { get; set; }

        public string NeighborHood { get; set; }

        public string City { get; set; }

        public string Country { get; set; }        
    }
}