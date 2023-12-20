using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsDTO
{
    public class OrderItemDTO
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("quantity")]
        public int Quantity {  get; set; }
        [Column("order_id")]
        public OrderDTO order { get; set; }
        [Column("product_id")]
        public ProductDTO product { get; set; }

        
    }
}
