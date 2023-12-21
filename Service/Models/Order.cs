using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Models
{
    public class Order
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("order_date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public ICollection<Customer> Customers { get; set; }

        
    }
}
