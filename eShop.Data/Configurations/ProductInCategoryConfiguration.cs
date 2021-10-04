using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            builder.HasKey(p => new { p.CategoryId, p.ProductId });

            builder.HasOne(p => p.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.ProductId);

            builder.HasOne(p => p.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.CategoryId);
        }
    }
}
