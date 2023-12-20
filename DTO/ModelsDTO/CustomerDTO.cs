using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.ModelsDTO
{
    public class CustomerDTO
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Required]
        [Column("first_name")]
        public string FristName { get; set; }
        [Required]
        [Column("last_name")]
        public string LastName { get; set; }
        [Required]
        [Column("telephone")]
        public int Telephone { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        
        public DateTime createdAt {  get; set; }
        public DateTime modifiedAt { get; set; }

        
    }
}
