using DataAccessLayer.Data;
using DataAccessLayer.ModelsDTO;
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

        public Task AddCategoryAsync(CategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public Task<CategoryDTO> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(CategoryDTO category)
        {
            throw new NotImplementedException();
        }
    }

}
