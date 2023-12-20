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
        Task<IEnumerable<InstockEntity>> GetInstocksAsync();
        Task<InstockEntity> GetInstockByIdAsync(int id);
        Task<InstockEntity> AddInstockAsync(InstockEntity instock);
        Task UpdateInstockAsync(InstockEntity instock);
        Task DeleteInstockAsync(int id);
    }
}
