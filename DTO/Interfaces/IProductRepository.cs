using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface IProductRepository
    {
        public List<ProductEntity> GetProducts();
        public ProductEntity? GetProductById(int id);
        public ProductEntity? AddProduct(ProductEntity product);
        void UpdateProduct(ProductEntity product);
        void DeleteProduct(int id);
    }
}
