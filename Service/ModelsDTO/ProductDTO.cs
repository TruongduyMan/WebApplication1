using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.ModelsDTO
{
    public class ProductDTO
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Required]
        [Column("product_name")]
        public string ProductName { get; set; }
        [Required]
        [Column("price")]
        public decimal Price { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("category_id")]
        public ICollection<CategoryDTO> Categories { get; set; }
        public InstockDTO Instocks { get; set; }
        
    }
}
