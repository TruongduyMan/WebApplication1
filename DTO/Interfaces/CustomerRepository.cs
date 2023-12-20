using DataAccessLayer.Data;
using DataAccessLayer.ModelsDTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Interfaces
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<CustomerDTO> AddCustomerAsync(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleleCustomerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDTO> GetCustomerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomersAsync()
        {
            return await _dbContext.Customers.ToListAsync();
        }

        public Task UpdateCustomerAsync(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }
    }

}
