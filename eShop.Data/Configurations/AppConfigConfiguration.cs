using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configuations
{
    /*--- https://www.learnentityframeworkcore.com/configuration/fluent-api ---*/
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        void IEntityTypeConfiguration<AppConfig>.Configure(EntityTypeBuilder<AppConfig> builder)
        {
            // Name of table in database
            builder.ToTable("AppConfigs");

            // Primary key in table
            builder.HasKey(p => p.Key);

            // Property
            builder.Property(p => p.Value).IsRequired(true);
        }
    }
}
