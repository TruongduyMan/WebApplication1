using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public Product product { get; set; }
        public Payment payment { get; set; }
        public Customer customer { get; set; }

        
    }
}
