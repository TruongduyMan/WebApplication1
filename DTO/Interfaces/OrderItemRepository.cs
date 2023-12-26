using DataAccessLayer.Data;
using DataAccessLayer.ModelsEntity;
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

        public OrderItemEntity? AddOrderItems(OrderItemEntity orderItems)
        {
            _dbContext.OrderItems.Add(orderItems);
            _dbContext.SaveChanges();
            return orderItems;
        }

        public void DeleteOrderItems(int id)
        {
            var order = _dbContext.OrderItems.Find(id);
            if(order != null)
            {
                _dbContext.OrderItems.Remove(order!);
                _dbContext.SaveChanges();

            }
        }

        public List<OrderItemEntity> GetAllOrderItems()
        {
            return _dbContext.OrderItems.ToList();
        }

        public OrderItemEntity? GetOrderItemsById(int id)
        {
            return _dbContext.OrderItems.FirstOrDefault(o => o.Id == id);
        }

        public void UpdateOrderItems(OrderItemEntity orderItems)
        {
            _dbContext.OrderItems.Update(orderItems);
        }
    }
}
