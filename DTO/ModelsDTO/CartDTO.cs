using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsDTO
{
    public class CartDTO
    {
        [Key]
        [Column("id")]
        public int ID {  get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("quantity")]
        public int Quantity {  get; set; }
        [Column("product_id")]
        public ProductDTO product { get; set; }
        [Column("secction_id")]
        public SectionDTO section { get; set; }

       
    }
}
