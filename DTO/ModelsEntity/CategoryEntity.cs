using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.ModelsEntity
{
    public class CategoryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("category_name")]
        public string categoryName { get; set; }
        [Column("description")]
        public string categoryDescription { get; set; }

        
    }
}
