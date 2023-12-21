using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsEntity
{
    public class SectionEntity
    {
        [Key]
        [Column("id")]
        public int ID {  get; set; }
        [Column("total")]
        public decimal Total {  get; set; }
        [Column("customer_id")]
        public ICollection<CustomerEntity> customer { get; set; }

        
    }
}
