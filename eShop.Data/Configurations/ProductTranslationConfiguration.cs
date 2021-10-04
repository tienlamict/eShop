using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslations");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);

            builder.Property(p => p.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(p => p.Details).HasMaxLength(500);


            builder.Property(p => p.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(p => p.Language).WithMany(p => p.ProductTranslations).HasForeignKey(p => p.LanguageId);

            builder.HasOne(p => p.Product).WithMany(p => p.ProductTranslations).HasForeignKey(p => p.ProductId);
        }
    }
}
