using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsDTO
{
    public class InstockDTO
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("quantity")]
        public int Quantity { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;

        
    }
}
