
using Service.ModelsDTO;


namespace Service.Services
{
    public interface ICustomerService
    {
        public List<CustomerDTO> GetAllCustomer();
        public CustomerDTO? GetCustomerById(int id);
        public CustomerDTO? AddCustomer(CustomerDTO customer);
        void UpdateCustomer(CustomerDTO customer);
        void DeleteCustomer(int id);

    }
}