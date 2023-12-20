using DataAccessLayer.Data;
using DataAccessLayer.ModelsDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderItemRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<OrderItemDTO> AddOrderItemsAsync(OrderItemDTO orderItems)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderItemsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OrderItemDTO>> GetAllOrderItemsAsync()
        {
            return await _dbContext.OrderItems.ToListAsync();
        }

        public Task<OrderItemDTO> GetOrderItemsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderItemsAsync(OrderItemDTO orderItems)
        {
            throw new NotImplementedException();
        }
    }
}
