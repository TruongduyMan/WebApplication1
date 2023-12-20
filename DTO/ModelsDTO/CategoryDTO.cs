using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.ModelsDTO
{
    public class CategoryDTO
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
