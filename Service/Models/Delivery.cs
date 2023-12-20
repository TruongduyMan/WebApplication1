using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Delivery
    {
        [Key]
        public int ID { get; set; }
        public string Status { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
    }
}
