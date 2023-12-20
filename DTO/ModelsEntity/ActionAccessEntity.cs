using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ModelsEntity
{
    public class ActionAccessEntity
    {
        public bool success {  get; set; }
        public string? error {  get; set; }
        public List<int> objectID { get; set; }
    }
}
