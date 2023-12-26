using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface IOrderItemRepository
    {
        public List<OrderItemEntity> GetAllOrderItems();
        public OrderItemEntity? GetOrderItemsById(int id);
        public OrderItemEntity? AddOrderItems(OrderItemEntity orderItems);
        void UpdateOrderItems(OrderItemEntity orderItems);
        void DeleteOrderItems(int id);
    }
}