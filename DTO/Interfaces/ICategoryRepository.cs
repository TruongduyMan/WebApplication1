using DataAccessLayer.ModelsDTO;

namespace DataAccessLayer.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<CategoryDTO> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(CategoryDTO category);
        Task UpdateCategoryAsync(CategoryDTO category);
        Task DeleteCategoryAsync(int id);   
    }
}
