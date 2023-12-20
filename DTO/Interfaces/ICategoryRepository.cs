using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryEntity>> GetCategoriesAsync();
        Task<CategoryEntity> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(CategoryEntity category);
        Task UpdateCategoryAsync(CategoryEntity category);
        Task DeleteCategoryAsync(int id);   
    }
}
