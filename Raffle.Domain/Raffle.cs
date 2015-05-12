using System.Collections.Generic;

namespace Raffle.Domain
{
    public class Raffle
    {
        public int Id { get; set; }

        public List<int> NumbersOfRaffles { get; set; }

        public Product Product { get; set; }

        public int Price { get; set; }
    } 
    } 
}
