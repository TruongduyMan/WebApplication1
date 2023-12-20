using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Section
    {
        [Key]
        public int ID { get; set; }
        public decimal Total { get; set; }
        public Customer customer { get; set; }

        
    }
}