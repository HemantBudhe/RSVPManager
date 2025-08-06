namespace RSVPManager.API.Model
{
    public class Event
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }
        public DateTime DateTime { get; set; }
        public string BannerUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Guest> Guests { get; set; }
    }
}
