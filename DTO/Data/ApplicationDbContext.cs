
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CartEntity> Carts { get; set; }
        public DbSet<InstockEntity> Instocks { get; set; }
        public DbSet<PaymentEntity> Payments { get; set;}
        public DbSet<SectionEntity> Sections { get; set; }
        public DbSet<OrderItemEntity> OrderItems { get; set; }
    }
}
