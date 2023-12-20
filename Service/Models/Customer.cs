using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FristName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Telephone { get; set; }
        [Required]
        public string Email { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime modifiedAt { get; set; }

        
    }
}
