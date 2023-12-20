using Service.Models;

namespace Service.Services
{
    public interface IOrderItemService
    {
        Task<IEnumerable<OrderItem>> GetAllOrderItem();
        Task<OrderItem> GetOrderItemById(int id);
        Task<OrderItem> AddOrderItem(OrderItem orderItem);
        Task UpdateOrderItem(OrderItem orderItem);
        Task DeleteOrderItem(int id);

    }
}