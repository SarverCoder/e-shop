using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace e_shop.DataAccess
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<StaffAccount> StaffAccounts { get; set; }
        public DbSet<StaffRole> StaffRoles { get; set; }
        public DbSet<Role> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             var ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=8544;Database=eCommerce";

            optionsBuilder
                .UseNpgsql(ConnectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
            .HasKey(pc => new
            {
                pc.ProductId,
                pc.CategoryId
            });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);



            modelBuilder.Entity<ProductTag>()
                .HasKey(pt => new
                {
                    pt.ProductId,
                    pt.TagId
                });

            modelBuilder.Entity<ProductTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(x => x.ProductTags)
                .HasForeignKey(pt  => pt.TagId);

            modelBuilder.Entity<ProductTag>()
                .HasOne(pt => pt.Product)
                .WithMany(x => x.ProductTags)
                .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<StaffAccount>(builder =>
            {
               

                builder.Property(x => x.Id)
                .HasMaxLength(100);


            });

            modelBuilder.Entity<StaffRole>(builder =>
            {
                builder.HasKey(k => new
                {
                    k.StaffID,
                    k.RoleId
                });

                builder.HasOne(x => x.StaffAccount)
                .WithMany(x => x.StaffRoles)
                .HasForeignKey(sr => sr.StaffID);

                builder
                .HasOne(sr => sr.Role)
                .WithMany(x => x.StaffRoles)
                .HasForeignKey(sr => sr.RoleId);
            });



        }
    }
}
