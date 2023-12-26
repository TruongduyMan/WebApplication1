using Service.ModelsDTO;

namespace Service.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategory();
        Task<CategoryDTO> GetCategoryById(int id);
        Task<CategoryDTO> AddCategory(CategoryDTO category);
        Task UpdateCategory(CategoryDTO category);
        Task DeleteCategory(int id);

    }
}