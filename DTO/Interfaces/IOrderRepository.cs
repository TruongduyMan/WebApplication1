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
        public List<OrderEntity> GetAllOrders();
        public OrderEntity? GetOrderById(int id);
        public OrderEntity? AddOrder(OrderEntity order);
        void DeleteOrder(int id);
        void UpdateOrder(OrderEntity order);
    }
}
