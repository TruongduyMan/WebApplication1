using DataAccessLayer.Data;
using DataAccessLayer.ModelsDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public class InstockRepository : IInstockRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public InstockRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<InstockDTO> AddInstockAsync(InstockDTO instock)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInstockAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<InstockDTO> GetInstockByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<InstockDTO>> GetInstocksAsync()
        {
            return await _dbContext.Instocks.ToListAsync(); 
        }

        public Task UpdateInstockAsync(InstockDTO instock)
        {
            throw new NotImplementedException();
        }
    }
}
