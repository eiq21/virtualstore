using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Configurations
{
    public class BrandConfiguration : BaseEntityConfiguration<Brand>
    {
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brand", "Catalog");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            base.Configure(builder);
        }

    }
}
