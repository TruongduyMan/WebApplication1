using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Instock
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;

        
    }
}