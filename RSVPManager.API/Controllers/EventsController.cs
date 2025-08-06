namespace RSVPManager.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RSVPManager.API.DTO;
    using RSVPManager.API.Model;

    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EventsController(AppDbContext context)
        {
            _context = context;
        }

        // POST /api/events
        [HttpPost]
        public async Task<ActionResult<EventResponseDto>> CreateEvent([FromBody] CreateEventDto dto)
        {
            var newEvent = new Event
            {
                Title = dto.Title,
                Description = dto.Description,
                Venue = dto.Venue,
                DateTime = dto.DateTime,
                BannerUrl = dto.BannerUrl
            };

            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEventById), new { id = newEvent.Id }, new EventResponseDto
            {
                Id = newEvent.Id,
                Title = newEvent.Title,
                Description = newEvent.Description,
                Venue = newEvent.Venue,
                DateTime = newEvent.DateTime,
                BannerUrl = newEvent.BannerUrl
            });
        }

        // GET /api/events/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<EventResponseDto>> GetEventById(Guid id)
        {
            var ev = await _context.Events.FindAsync(id);

            if (ev == null)
                return NotFound();

            return new EventResponseDto
            {
                Id = ev.Id,
                Title = ev.Title,
                Description = ev.Description,
                Venue = ev.Venue,
                DateTime = ev.DateTime,
                BannerUrl = ev.BannerUrl
            };
        }
    }

}
