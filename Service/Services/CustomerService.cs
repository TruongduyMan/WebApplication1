using AutoMapper;
using DataAccessLayer.Interfaces;
using Service.Models;

namespace Service.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<Customer> AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomer(int id)
        {
            return _repository.DeleleCustomerAsync(id);
        }

        public Task<IEnumerable<Customer>> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
