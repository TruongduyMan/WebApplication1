using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsEntity
{
    public class DeliveryEntity
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("product_id")]
        public ProductEntity Product { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

       
    }
}
