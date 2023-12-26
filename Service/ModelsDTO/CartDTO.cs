using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.ModelsDTO
{
    public class CartDTO
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Required]
        [Column("Name")]
        public string Name { get; set; }
        [Required]
        [Column("quantity")]
        public int Quantity { get; set; }
        public ProductDTO Product { get; set; }
        public ICollection<SectionDTO> Section { get; set; }

        
    }
}
