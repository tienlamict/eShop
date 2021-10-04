using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).IsRequired().IsUnicode(false).HasMaxLength(5);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(20);
        }
    }
}
