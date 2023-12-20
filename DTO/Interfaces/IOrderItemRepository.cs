using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface IOrderItemRepository
    {
        Task<IEnumerable<OrderItemEntity>> GetAllOrderItemsAsync();
        Task<OrderItemEntity> GetOrderItemsByIdAsync(int id);
        Task<OrderItemEntity> AddOrderItemsAsync(OrderItemEntity orderItems);
        Task UpdateOrderItemsAsync(OrderItemEntity orderItems);
        Task DeleteOrderItemsAsync(int id);
    }
}