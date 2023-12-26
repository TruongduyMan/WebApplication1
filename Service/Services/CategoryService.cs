using AutoMapper;
using DataAccessLayer.Interfaces;
using Service.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<CategoryDTO> AddCategory(CategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDTO>> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(CategoryDTO category)
        {
            throw new NotImplementedException();
        }
    }
}
