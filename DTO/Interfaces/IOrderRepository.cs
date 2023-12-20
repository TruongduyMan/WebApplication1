using DataAccessLayer.ModelsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderEntity>> GetAllOrdersAsync();
        Task<OrderEntity> GetOrderByIdAsync(int id);
        Task<OrderEntity> AddOrderAsync(OrderEntity order);
        Task DeleteOrderAsync(int id);
        Task UpdateOrderAsync(OrderEntity order);
    }
}
