using Microsoft.EntityFrameworkCore;
using RSVPManager.API.Model;
using System.Collections.Generic;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Event> Events { get; set; }
    public DbSet<Guest> Guests { get; set; }
}