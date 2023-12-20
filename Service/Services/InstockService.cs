using AutoMapper;
using DataAccessLayer.Interfaces;
using Service.Models;
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

        public Task<Instock> AddInstock(Instock instock)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInstock(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Instock>> GetAllInstock()
        {
            throw new NotImplementedException();
        }

        public Task<Instock> GetInstockById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateInstock(Instock instock)
        {
            throw new NotImplementedException();
        }
    }
}
