using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface ICategoryRepository
    {
        public List<CategoryEntity> GetCategories();
        public CategoryEntity? GetCategoryById(int id);
        public CategoryEntity? AddCategory(CategoryEntity category);
        void UpdateCategory(CategoryEntity category);
        void DeleteCategory(int id);   
    }
}
