namespace break_away.Data;

using break_away.Data.Configurations;
using break_away.Models;
using Microsoft.EntityFrameworkCore;

public class BreakAwayContext: DbContext
{
    public BreakAwayContext(DbContextOptions<BreakAwayContext> options) : base(options)
    {
    }
    
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Lodging> Lodgings { get; set; }
    public DbSet<Trip> Trips { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DestinationConfiguration());
        modelBuilder.ApplyConfiguration(new LodgingConfiguration());
        modelBuilder.ApplyConfiguration(new TripConfiguration());
    }
}