namespace break_away.Data;

using System.Reflection;
using break_away.Models;
using Microsoft.EntityFrameworkCore;

public class BreakAwayContext: DbContext
{
    public BreakAwayContext(DbContextOptions<BreakAwayContext> options) : base(options)
    {
    }
    
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Lodging> Lodgings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Destination>()
                    .Property(d => d.Name)
                    .IsRequired()
                    .HasMaxLength(200);
        modelBuilder.Entity<Destination>()
                    .Property(d => d.Description)
                    .HasMaxLength(500);
        
        modelBuilder.Entity<Lodging>()
                    .Property(l => l.Name)
                    .IsRequired()
                    .HasMaxLength(200);
    }
}