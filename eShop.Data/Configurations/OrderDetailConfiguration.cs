using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(p => new { p.OrderId, p.ProductId });

            builder.HasOne(p => p.Order).WithMany(p => p.OrderDetails).HasForeignKey(p => p.OrderId);

            builder.HasOne(p => p.Product).WithMany(p => p.OrderDetails).HasForeignKey(p => p.ProductId);
        }
    }
}
