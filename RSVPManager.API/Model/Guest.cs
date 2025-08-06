namespace RSVPManager.API.Model
{
    public class Guest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string EmailOrPhone { get; set; }
        public bool Attending { get; set; }
        public int GuestCount { get; set; }

        public Guid EventId { get; set; }
        public Event Event { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
