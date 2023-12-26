using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface ICustomerRepository
    {
        public List<CustomerEntity> GetCustomers();
        public CustomerEntity? GetCustomerById(int id);
        public CustomerEntity? AddCustomer(CustomerEntity customer);
        void UpdateCustomer(CustomerEntity customer);
        void DeleteCustomer(int id);

    }
}
