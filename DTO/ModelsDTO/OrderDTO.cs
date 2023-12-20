using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.ModelsDTO
{
    public class OrderDTO
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("order_date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Column("product_id")]
        public ProductDTO product { get; set; }
        public PaymentDTO payment { get; set; }
        [Column("customer_id")]
        public CustomerDTO customer { get; set; }

        
    }
}