using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Configurations
{
    public class CategoryConfiguration: BaseEntityConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category", "Catalog");

            builder.Property(e => e.Name).IsRequired().HasMaxLength(60);
            builder.Property(e => e.Description).HasMaxLength(256);

            base.Configure(builder);
        }
    }
}
