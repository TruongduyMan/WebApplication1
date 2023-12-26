using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.ModelsEntity
{
    public class OrderEntity
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("order_date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Column("customer_id")]
        public CustomerEntity Customer { get; set; }

        
    }
}