using System.Collections.Generic;

namespace Raffle.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public List<Image> Images { get; set; }
               
    }
}
