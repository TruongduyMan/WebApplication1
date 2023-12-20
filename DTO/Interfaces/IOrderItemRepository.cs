using DataAccessLayer.ModelsDTO;

namespace DataAccessLayer.Interfaces
{
    public interface IOrderItemRepository
    {
        Task<IEnumerable<OrderItemDTO>> GetAllOrderItemsAsync();
        Task<OrderItemDTO> GetOrderItemsByIdAsync(int id);
        Task<OrderItemDTO> AddOrderItemsAsync(OrderItemDTO orderItems);
        Task UpdateOrderItemsAsync(OrderItemDTO orderItems);
        Task DeleteOrderItemsAsync(int id);
    }
}