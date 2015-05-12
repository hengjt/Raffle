namespace Raffle.Domain
{
    public class User
    {
        public int  Id { get; set; }

        public string Name { get; set; }

        public string Mail { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public Address Address { get; set; }

        public string Phone { get; set; }

        public bool Autenticate(string login, string password)
        {
            return (login == Mail || login == NickName) && password == Password;            
        }

        public int ProductId { get; set; }
    }
}
