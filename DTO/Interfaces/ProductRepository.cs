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

        public ProductEntity AddProduct(ProductEntity product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var product = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(product!);
        }

        public ProductEntity? GetProductById(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ID == id);
            
        }

        public List<ProductEntity> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void UpdateProduct(ProductEntity product)
        {
            _dbContext.Products.Update(product);
        }
    }
}
