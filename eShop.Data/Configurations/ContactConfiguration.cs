using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Name).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Email).HasMaxLength(200).IsRequired();

            builder.Property(p => p.PhoneNumber).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Message).IsRequired();
        }
    }
}
