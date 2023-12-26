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
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public OrderEntity? AddOrder(OrderEntity order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return order;
        }

        public void DeleteOrder(int id)
        {
            var order = _dbContext.Orders.Find(id);
            if(order != null)
            {
              _dbContext.Orders.Remove(order!);
              _dbContext.SaveChanges();
            }
        }

        public List<OrderEntity> GetAllOrders()
        {
            return _dbContext.Orders.ToList();
        }

        public OrderEntity? GetOrderById(int id)
        {
            return _dbContext.Orders.FirstOrDefault(x => x.ID == id);
        }

        public void UpdateOrder(OrderEntity order)
        {
            _dbContext.Orders.Update(order);
        }
    }
}
