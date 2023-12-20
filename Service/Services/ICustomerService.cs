using Service.Models;

namespace Service.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomer();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> AddCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task DeleteCustomer(int id);

    }
}