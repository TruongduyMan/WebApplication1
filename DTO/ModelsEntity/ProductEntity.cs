using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.ModelsEntity
{
    public class ProductEntity
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
        public ICollection<CategoryEntity> Categories { get; set; }
        
    }
}
