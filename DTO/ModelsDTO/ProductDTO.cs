using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.ModelsDTO
{
    public class ProductDTO
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("product_name")]
        public string ProductName { get; set; }
        [Column("product_price")]
        public decimal Price { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("image")]
        public string Image {  get; set; }
        [Column("category_id")]
        public CategoryDTO category { get; set; }
        [Column("instock_id")]
        public InstockDTO instock { get; set; }

        
    }
}
