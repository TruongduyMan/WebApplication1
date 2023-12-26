using AutoMapper;
using DataAccessLayer.Interfaces;
using DataAccessLayer.ModelsEntity;
using Service.ModelsDTO;

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

        public CustomerDTO? AddCustomer(CustomerDTO customer)
        {
            CustomerEntity entity = _mapper.Map<CustomerEntity>(customer);
            CustomerEntity repository = _repository.AddCustomer(entity);
            CustomerDTO action = _mapper.Map<CustomerDTO>(repository);
            return action;
        }

        public void DeleteCustomer(int id)
        {
            _repository.GetCustomerById(id);
            _repository.DeleteCustomer(id); 
        }

        public List<CustomerDTO> GetAllCustomer()
        {
            List<CustomerEntity> list = _repository.GetCustomers();
            List<CustomerDTO> entities = _mapper.Map<List<CustomerDTO>>(list);
            return entities;

        }

        public CustomerDTO? GetCustomerById(int id)
        {
            CustomerEntity? entity = _repository.GetCustomerById(id);
            CustomerDTO customer = _mapper.Map<CustomerDTO>(entity);
            return customer;
        }

        public void UpdateCustomer(CustomerDTO customer)
        {
            CustomerEntity request = _mapper.Map<CustomerEntity>(customer);
            _repository.UpdateCustomer(request); 
        }

    }
}
