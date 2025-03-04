using e_shop.DataAccess.ModelConfigurations;
using e_shop.Domain.Entities;
using e_shop.Domain.ViewsModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace e_shop.DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<StaffAccount> StaffAccounts { get; set; }
        public DbSet<StaffRole> StaffRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LastYearOrderModel> LastYearOrderModels { get; set; }
        public DbSet<OrdersBetween> BetweenOrders { get; set; }

        //public ShopContext()
        //{
        //    Database.EnsureCreated();
        //}


      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTagConfiguration());
            modelBuilder.ApplyConfiguration(new StaffRoleConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());

            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Hammasini olish

            modelBuilder.Entity<LastYearOrderModel>()
                .ToView("LastYearOrdersView")
                .HasNoKey();

            modelBuilder.Entity<OrdersBetween>()
                .ToSqlQuery(@"select * from public.""SP_GetOrders""('2024-01-01', '2024-12-31')")
                .HasNoKey();



            modelBuilder.Entity<StaffAccount>(builder =>
            {
                builder.Property(x => x.Id)
                .HasMaxLength(100);
            });

            modelBuilder.Entity<Order>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId);



        }

        //public override int SaveChanges()
        //{
        //    var entries = ChangeTracker.Entries();

        //    var addedEntries = entries.Where(e => e.State == EntityState.Added);

        //    var updateEntries = entries.Where(x => x.State == EntityState.Modified);

        //    foreach( var entry in addedEntries )
        //    {
        //        if (entry.Entity is IAuditable entity)
        //        {
        //            entity.CreatedAt = DateTime.UtcNow;
        //            entity.CreatedBy = 1;
        //        }
        //    }
        //    return base.SaveChanges();
        //}




    }
}
