using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string PaymentType { get; set; }
        [Required]
        public string Provider { get; set; }
        public int AccountNo { get; set; }
        public Order order { get; set; }

        
    }
}