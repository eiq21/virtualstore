using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Configurations
{
    public class ProductConfiguration : BaseEntityConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", "Catalog");

            builder.Property(e => e.Name).IsRequired().HasMaxLength(60);
            builder.Property(e => e.Number).IsRequired()
                .HasMaxLength(25)
                .IsUnicode()
                .HasComputedColumnSql($"'P'+ RIGHT(REPLICATE('0', 10) + CONVERT(NVARCHAR(10),[ProductId]), 10)");

            builder.HasOne(d => d.Brand)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.BrandId);

            builder.HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(c => c.CategoryId);

            base.Configure(builder);
        }
    }
}
