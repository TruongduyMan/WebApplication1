using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }

        
    }
}