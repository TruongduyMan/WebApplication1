using DataAccessLayer.Data;
using DataAccessLayer.ModelsEntity;
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

        public Task<CustomerEntity> AddCustomerAsync(CustomerEntity customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleleCustomerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerEntity> GetCustomerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerEntity>> GetCustomersAsync()
        {
            return await _dbContext.Customers.ToListAsync();
        }

        public Task UpdateCustomerAsync(CustomerEntity customer)
        {
            throw new NotImplementedException();
        }
    }

}
