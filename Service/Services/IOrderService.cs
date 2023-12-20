using Service.Models;

namespace Service.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrder();
        Task<Order> GetOrderById(int id);
        Task<Order> AddOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(int id);

    }
}