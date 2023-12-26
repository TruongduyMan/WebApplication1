using Service.ModelsDTO;

namespace Service.Services
{
    public interface IProductService
    {
        public List<ProductDTO> GetAllProduct();
        public ProductDTO GetProductById(int id);
        public ProductDTO AddProduct(ProductDTO product);
        void UpdateProduct(ProductDTO product);
        void DeleteProduct(int id);

    }
}