namespace break_away.Data.Configurations;

using break_away.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InternetSpecialConfiguration: IEntityTypeConfiguration<InternetSpecial>
{
    public void Configure(EntityTypeBuilder<InternetSpecial> builder)
    {
        builder.Property(i => i.AccommodationId).IsRequired();
    }
}