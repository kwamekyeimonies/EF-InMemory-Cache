namespace InMemory_Cache.Models
{
    public class Users
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int RacingNumber { get; set; }

        public string? Team { get; set; }
    }
}