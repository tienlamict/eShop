using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).UseIdentityColumn();

            builder.HasOne(p => p.Product).WithMany(p => p.Carts).HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.AppUser).WithMany(p => p.Carts).HasForeignKey(p => p.UserId);
        }
    }
}
