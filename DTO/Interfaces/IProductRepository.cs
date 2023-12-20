using DataAccessLayer.ModelsDTO;

namespace DataAccessLayer.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int id);
        Task<ProductDTO> AddProductAsync(ProductDTO product);
        Task UpdateProductAsync(ProductDTO product);
        Task DeleteProductAsync(int id);
    }
}
