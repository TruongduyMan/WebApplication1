using DataAccessLayer.Data;
using DataAccessLayer.ModelsEntity;
using Microsoft.Data.SqlClient;
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

        public CustomerEntity AddCustomer(CustomerEntity customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.ID == id);
            if(customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges(true);
            }
        }

        public CustomerEntity? GetCustomerById(int id)
        {
            return _dbContext.Customers.FirstOrDefault(c => c.ID == id);
        }

        public List<CustomerEntity> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public void UpdateCustomer(CustomerEntity customer)
        {
            _dbContext.Customers.Update(customer);
        }
    }

}
