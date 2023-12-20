using DataAccessLayer.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IInstockRepository
    {
        Task<IEnumerable<InstockDTO>> GetInstocksAsync();
        Task<InstockDTO> GetInstockByIdAsync(int id);
        Task<InstockDTO> AddInstockAsync(InstockDTO instock);
        Task UpdateInstockAsync(InstockDTO instock);
        Task DeleteInstockAsync(int id);
    }
}
