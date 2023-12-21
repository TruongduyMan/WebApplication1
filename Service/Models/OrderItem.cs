using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        public ICollection<Order> order { get; set; }
        public ICollection<Product> product { get; set; }

        
    }
}
