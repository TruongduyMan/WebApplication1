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
    public class SectionRepository : ISectionRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SectionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<SectionDTO> AddSectionAsync(SectionDTO section)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSectionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SectionDTO> GetaAllSectionByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SectionDTO>> GetAllSectionAsync()
        {
            return await _dbContext.Sections.ToListAsync();
        }

        public Task UpdateSectionAsync(SectionDTO section)
        {
            throw new NotImplementedException();
        }
    }
}
