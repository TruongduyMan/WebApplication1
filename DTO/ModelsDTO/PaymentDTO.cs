using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsDTO
{
    public class PaymentDTO
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        public string PaymentType {  get; set; }
        [Required]
        public string Provider {  get; set; }
        public int AccountNo {  get; set; }
        public OrderDTO order { get; set; }

    }
}
