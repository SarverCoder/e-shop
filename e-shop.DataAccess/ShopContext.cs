using e_shop.DataAccess.ModelConfigurations;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Reflection;

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

        //public ShopContext()
        //{
        //    Database.EnsureCreated();
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             var ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=8544;Database=eCommerce";

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseNpgsql(ConnectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTagConfiguration());
            modelBuilder.ApplyConfiguration(new StaffRoleConfiguration());

           // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           // Hammasini olish
           

            modelBuilder.Entity<StaffAccount>(builder =>
            {
               

                builder.Property(x => x.Id)
                .HasMaxLength(100);


            });           

        }

      


    }
}
