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

        public SectionEntity? AddSection(SectionEntity section)
        {
            _dbContext.Sections.Add(section);
            _dbContext.SaveChanges();
            return section;
        }

        public void DeleteSection(int id)
        {
            var section = _dbContext.Sections.Find(id);
            if(section != null) { 
                _dbContext.Sections.Remove(section!);
                _dbContext.SaveChanges();
            }
        }

        public SectionEntity? GetaAllSectionByID(int id)
        {
            return _dbContext.Sections.FirstOrDefault(s => s.ID == id);    
        }

        public List<SectionEntity> GetAllSection()
        {
            return _dbContext.Sections.ToList();
        }

        public void UpdateSection(SectionEntity section)
        {
            _dbContext.Sections.Update(section);
        }
    }
}
