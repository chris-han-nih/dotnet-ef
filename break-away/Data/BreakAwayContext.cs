namespace break_away.Data;

using break_away.Models;
using Microsoft.EntityFrameworkCore;

public class BreakAwayContext: DbContext
{
    public BreakAwayContext(DbContextOptions<BreakAwayContext> options) : base(options)
    {
    }
    
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Lodging> Lodgings { get; set; }
}