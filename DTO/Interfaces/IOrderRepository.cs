using DataAccessLayer.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderDTO>> GetAllOrdersAsync();
        Task<OrderDTO> GetOrderByIdAsync(int id);
        Task<OrderDTO> AddOrderAsync(OrderDTO order);
        Task DeleteOrderAsync(int id);
        Task UpdateOrderAsync(OrderDTO order);
    }
}
