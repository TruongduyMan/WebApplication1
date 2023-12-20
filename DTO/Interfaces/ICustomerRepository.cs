using DataAccessLayer.ModelsDTO;

namespace DataAccessLayer.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerDTO>> GetCustomersAsync();
        Task<CustomerDTO> GetCustomerByIdAsync(int id);
        Task<CustomerDTO> AddCustomerAsync(CustomerDTO customer);
        Task UpdateCustomerAsync(CustomerDTO customer);
        Task DeleleCustomerAsync(int id);

    }
}
