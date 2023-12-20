using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsDTO
{
    public class ActionAccessDTO
    {
        public bool success {  get; set; }
        public string? error {  get; set; }
        public List<int> objectID { get; set; }
    }
}
