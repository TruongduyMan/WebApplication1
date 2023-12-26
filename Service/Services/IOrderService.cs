using Service.ModelsDTO;

namespace Service.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetAllOrder();
        Task<OrderDTO> GetOrderById(int id);
        Task<OrderDTO> AddOrder(OrderDTO order);
        Task UpdateOrder(OrderDTO order);
        Task DeleteOrder(int id);

    }
}