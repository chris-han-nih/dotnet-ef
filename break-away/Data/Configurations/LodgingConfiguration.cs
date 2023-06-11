namespace break_away.Data.Configurations;

using break_away.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class LodgingConfiguration: IEntityTypeConfiguration<Lodging>
{
    public void Configure(EntityTypeBuilder<Lodging> builder)
    {
        builder.Property(l => l.Name)
               .IsRequired()
               .HasMaxLength(200);
        builder.Property(l => l.MilesFromNearestAirport)
               .HasPrecision(18, 3);
    }
}