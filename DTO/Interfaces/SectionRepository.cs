using DataAccessLayer.Data;
using DataAccessLayer.ModelsEntity;
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

        public Task<SectionEntity> AddSectionAsync(SectionEntity section)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSectionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SectionEntity> GetaAllSectionByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SectionEntity>> GetAllSectionAsync()
        {
            return await _dbContext.Sections.ToListAsync();
        }

        public Task UpdateSectionAsync(SectionEntity section)
        {
            throw new NotImplementedException();
        }
    }
}
