using DataAccessLayer.Data;
using DataAccessLayer.ModelsDTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Interfaces
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<ProductDTO> AddProductAsync(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public Task UpdateProductAsync(ProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
