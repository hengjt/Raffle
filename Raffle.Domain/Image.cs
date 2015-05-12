namespace Raffle.Domain
{
    public class Image
    {
        public int Id { get; set; }


        public int ProductId { get; set; }

        public string Path { get; set; }

        public string Name { get; set; }
    }
}