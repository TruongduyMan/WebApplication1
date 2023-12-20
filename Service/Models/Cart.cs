using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Product product { get; set; }
        public Section section { get; set; }

        
    }
}
