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
    public class InstockRepository : IInstockRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public InstockRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public InstockEntity? AddInstock(InstockEntity instock)
        {
            _dbContext.Instocks.Add(instock);
            _dbContext.SaveChanges();
            return instock;
        }

        public void DeleteInstock(int id)
        {
            var instock = _dbContext.Instocks.Find(id);
            if(instock != null) { 
            
                _dbContext.Instocks.Remove(instock!);
                _dbContext.SaveChanges();
            }
        }

        public InstockEntity? GetInstockById(int id)
        {
            return _dbContext.Instocks.FirstOrDefault(i => i.Id == id);
        }

        public List<InstockEntity> GetInstocks()
        {
            return _dbContext.Instocks.ToList();
        }

        public void UpdateInstock(InstockEntity instock)
        {
            _dbContext.Instocks.Update(instock);
        }
    }
}
