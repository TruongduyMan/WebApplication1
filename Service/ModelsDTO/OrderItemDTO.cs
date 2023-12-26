using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.ModelsDTO
{
    public class OrderItemDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("order_id")]
        public int OrderId { get; set; }
        public ICollection<OrderDTO> Orders { get; set; }
        public ProductDTO Products { get; set; }

        
    }
}
