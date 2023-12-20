using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Category category { get; set; }
        public Instock instock { get; set; }

        
    }
}
