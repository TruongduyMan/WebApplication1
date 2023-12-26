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

        public CategoryEntity? AddCategory(CategoryEntity category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var category = _dbContext.Categories.Find(id);
            if (category != null)
            {
                _dbContext.Categories.Remove(category!);
                _dbContext.SaveChanges();
            
            }
        }

        public List<CategoryEntity> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public CategoryEntity? GetCategoryById(int id)
        {
            return _dbContext.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateCategory(CategoryEntity category)
        {
            _dbContext.Categories.Update(category);
        }
    }

}
