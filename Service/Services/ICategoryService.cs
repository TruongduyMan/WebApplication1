using Service.Models;

namespace Service.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategory();
        Task<Category> GetCategoryById(int id);
        Task<Category> AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(int id);

    }
}