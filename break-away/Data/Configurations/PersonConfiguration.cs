namespace break_away.Data.Configurations;

using break_away.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PersonConfiguration: IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(p => p.SocialSecurityNumber);
        builder.Property(p => p.SocialSecurityNumber)
               .ValueGeneratedNever();
        builder.OwnsOne(p => p.Address,
                        ad =>
                        {
                            ad.Property(a => a.City)
                              .HasMaxLength(100);
                            ad.Property(a => a.ZipCode)
                              .HasMaxLength(20);
                        });
    }
}