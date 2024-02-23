namespace TvoeTilo.Domain.Entities
{
    public class Client : Entity<Guid>
    {
        public required string PhoneNumber { get; set; }

        public required string Name { get; set; }
    }
}
