using AutoMapper;
using DataAccessLayer.Interfaces;
using DataAccessLayer.ModelsEntity;
using Service.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ProductDTO AddProduct(ProductDTO product)
        {
            ProductEntity entity = _mapper.Map<ProductEntity>(product);
            ProductEntity repository = _repository.AddProduct(entity);
            ProductDTO action = _mapper.Map<ProductDTO>(repository);
            return action;
        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
        }

        public List<ProductDTO> GetAllProduct()
        {
            List<ProductEntity> list = _repository.GetProducts();  
            List<ProductDTO> entities = _mapper.Map<List<ProductDTO>>(list);
            return entities;
        }

        public ProductDTO GetProductById(int id)
        {
            ProductEntity? product = _repository.GetProductById(id);
            ProductDTO productDTO = _mapper.Map<ProductDTO>(product);
            return productDTO;
        }

        public void UpdateProduct(ProductDTO product)
        {
            ProductEntity productEntity = _mapper.Map<ProductEntity>(product);
            _repository.UpdateProduct(productEntity);
        }
    }
}
