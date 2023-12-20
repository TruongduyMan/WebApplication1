using DataAccessLayer.Data;
using DataAccessLayer.ModelsEntity;
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

        public Task<ProductEntity> AddProductAsync(ProductEntity product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductEntity>> GetProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public Task UpdateProductAsync(ProductEntity product)
        {
            throw new NotImplementedException();
        }
    }
}
