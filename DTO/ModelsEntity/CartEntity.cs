using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsEntity
{
    public class CartEntity
    {
        [Key]
        [Column("id")]
        public int ID {  get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("quantity")]
        public int ProductId {  get; set; }
        public int SectionId { get; set; }
        public int Quantity {  get; set; }
        [Column("product_id")]
        public ICollection<ProductEntity> Product { get; set; }
        [Column("secction_id")]
        public ICollection<SectionEntity> Section { get; set; }

       
    }
}
