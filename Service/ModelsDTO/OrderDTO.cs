using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.ModelsDTO
{
    public class OrderDTO
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("order_date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Column("customer_id")]
        public ICollection<CustomerDTO> Customers { get; set; }

        
    }
}
