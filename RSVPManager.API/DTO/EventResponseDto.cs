namespace RSVPManager.API.DTO
{
    public class EventResponseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }
        public DateTime DateTime { get; set; }
        public string BannerUrl { get; set; }
    }
}
