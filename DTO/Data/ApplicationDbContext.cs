
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.ModelsDTO;

namespace DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerDTO> Customers { get; set; }
        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<OrderDTO> Orders { get; set; }
        public DbSet<CategoryDTO> Categories { get; set; }
        public DbSet<CartDTO> Carts { get; set; }
        public DbSet<InstockDTO> Instocks { get; set; }
        public DbSet<PaymentDTO> Payments { get; set;}
        public DbSet<SectionDTO> Sections { get; set; }
        public DbSet<OrderItemDTO> OrderItems { get; set; }
    }
}
