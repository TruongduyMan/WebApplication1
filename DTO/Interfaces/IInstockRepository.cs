using DataAccessLayer.ModelsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IInstockRepository
    {
        public List<InstockEntity> GetInstocks();
        public InstockEntity? GetInstockById(int id);
        public InstockEntity? AddInstock(InstockEntity instock);
        void UpdateInstock(InstockEntity instock);
        void DeleteInstock(int id);
    }
}
