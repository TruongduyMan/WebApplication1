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
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<OrderDTO> AddOrderAsync(OrderDTO order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrdersAsync()
        {
            return await _dbContext.Orders.ToListAsync();
        }

        public Task<OrderDTO> GetOrderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderAsync(OrderDTO order)
        {
            throw new NotImplementedException();
        }
    }
}
