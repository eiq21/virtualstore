using Catalog.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Configurations
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> 
        where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(40).HasDefaultValue("localhost");
            builder.Property(e => e.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
            builder.Property(e => e.LastModifiedBy).HasMaxLength(25).HasDefaultValue("localhost");
            builder.Property(e => e.LastModifiedAt).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
            builder.Property(e => e.IsEnable).IsRequired().HasDefaultValueSql("((1))");
        }
    }
}
