using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsEntity
{
    public class OrderItemEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("quantity")]
        public int Quantity {  get; set; }
        [Column("order_id")]
        public int ProductId { get; set; }
        public int OrderId {  get; set; }
        public ICollection<OrderEntity> Orders { get; set; }
        [Column("product_id")]
        public ICollection<ProductEntity> Products { get; set; }

        
    }
}
