using Service.Models;

namespace Service.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> GetProductById(int id);
        Task<Product> AddProductByName(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);

    }
}