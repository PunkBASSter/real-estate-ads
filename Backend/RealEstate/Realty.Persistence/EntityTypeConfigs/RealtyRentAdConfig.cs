using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty.Domain.Model;

namespace Realty.Persistence.EntityTypeConfigs
{
    public class RealtyRentAdConfig : IEntityTypeConfiguration<RealtyRentAd>
    {
        public void Configure(EntityTypeBuilder<RealtyRentAd> builder)
        {
            //builder.Ignore(e => e.DomainEvents);

            //builder.Property(t => t.Title)
            //    .HasMaxLength(200)
            //    .IsRequired();

            builder.Property(p => p.Title).HasMaxLength(100).IsUnicode().IsRequired();
            builder.Property(p => p.Description).IsUnicode().IsRequired();
            //price required?
        }
    }
}
