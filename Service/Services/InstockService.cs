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
    public class InstockService: IInstockService
    {
        private readonly IInstockRepository _repository;
        private readonly IMapper _mapper;

        public InstockService(IInstockRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<InstockDTO> AddInstock(InstockDTO instock)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInstock(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InstockDTO>> GetAllInstock()
        {
            throw new NotImplementedException();
        }

        public Task<InstockDTO> GetInstockById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateInstock(InstockDTO instock)
        {
            throw new NotImplementedException();
        }
    }
}
