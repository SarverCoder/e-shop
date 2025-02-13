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
    public class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
    {
        public void Configure(EntityTypeBuilder<ProductTag> modelBuilder)
        {
            modelBuilder
               .HasKey(pt => new
               {
                   pt.ProductId,
                   pt.TagId
               });

            modelBuilder
                .HasOne(pt => pt.Tag)
                .WithMany(x => x.ProductTags)
                .HasForeignKey(pt => pt.TagId);

            modelBuilder
                .HasOne(pt => pt.Product)
                .WithMany(x => x.ProductTags)
                .HasForeignKey(pt => pt.ProductId);

        }
    }
}
