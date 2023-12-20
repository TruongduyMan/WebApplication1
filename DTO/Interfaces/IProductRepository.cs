using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductEntity>> GetProductsAsync();
        Task<ProductEntity> GetByIdAsync(int id);
        Task<ProductEntity> AddProductAsync(ProductEntity product);
        Task UpdateProductAsync(ProductEntity product);
        Task DeleteProductAsync(int id);
    }
}
