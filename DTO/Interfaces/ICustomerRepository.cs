using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerEntity>> GetCustomersAsync();
        Task<CustomerEntity> GetCustomerByIdAsync(int id);
        Task<CustomerEntity> AddCustomerAsync(CustomerEntity customer);
        Task UpdateCustomerAsync(CustomerEntity customer);
        Task DeleleCustomerAsync(int id);

    }
}
