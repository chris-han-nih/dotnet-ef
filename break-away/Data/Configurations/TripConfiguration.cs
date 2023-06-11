namespace break_away.Data.Configurations;

using break_away.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TripConfiguration: IEntityTypeConfiguration<Trip>
{
    public void Configure(EntityTypeBuilder<Trip> builder)
    {
        builder.Property(t => t.Id).ValueGeneratedOnAdd();
        builder.Property(t => t.RowVersion)
               .IsRowVersion();
    }
}