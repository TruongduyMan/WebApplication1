using Service.ModelsDTO;

namespace Service.Services
{
    public interface IOrderItemService
    {
        Task<IEnumerable<OrderItemDTO>> GetAllOrderItem();
        Task<OrderItemDTO> GetOrderItemById(int id);
        Task<OrderItemDTO> AddOrderItem(OrderItemDTO orderItem);
        Task UpdateOrderItem(OrderItemDTO orderItem);
        Task DeleteOrderItem(int id);

    }
}