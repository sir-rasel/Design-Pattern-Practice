using Microsoft.EntityFrameworkCore;
using Repository_UnitOfWork_Pattern.src.Core.Domain;

namespace Repository_UnitOfWork_Pattern.src.Infrastructure.Persistence.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options)
            : base(options) { }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(productItem =>
            {
                productItem.Property(item => item.Name).IsRequired();
                productItem.Property(item => item.FullPrice).IsRequired();
                productItem.Property(item => item.BrandId).IsRequired();
            });

            modelBuilder.Entity<Brand>(brandItem =>
            {
                brandItem.Property(item => item.Name).IsRequired();
            });

            modelBuilder.Entity<Brand>()
                .Property(s => s.Id)
                 .ValueGeneratedNever();

            modelBuilder.Entity<Product>()
                .Property(s => s.Id)
                 .ValueGeneratedNever();
        }
    }
}
