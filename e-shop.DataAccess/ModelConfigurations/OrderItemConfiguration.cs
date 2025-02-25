using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DataAccess.ModelConfigurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(x => new
            {
                x.OrderId,
                x.ProductId
            });

            builder
                .HasOne(oi => oi.Product)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.ProductId);

            builder
                .HasOne(oi => oi.Order)
                .WithMany(c => c.OrderItems)
                .HasForeignKey(x => x.OrderId);

        }
    }
}
