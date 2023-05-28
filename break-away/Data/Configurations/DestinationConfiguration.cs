namespace break_away.Data.Configurations;

using break_away.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DestinationConfiguration: IEntityTypeConfiguration<Destination>
{
    public void Configure(EntityTypeBuilder<Destination> builder)
    {
        builder.Property(d => d.Name)
               .IsRequired()
               .HasMaxLength(200);
        builder.Property(d => d.Description)
               .HasMaxLength(500);
    }
}