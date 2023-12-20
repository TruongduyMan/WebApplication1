using DataAccessLayer.Data;
using DataAccessLayer.ModelsEntity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Interfaces
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddCategoryAsync(CategoryEntity category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryEntity>> GetCategoriesAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public Task<CategoryEntity> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(CategoryEntity category)
        {
            throw new NotImplementedException();
        }
    }

}
