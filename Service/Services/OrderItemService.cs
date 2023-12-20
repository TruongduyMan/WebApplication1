using AutoMapper;
using DataAccessLayer.Interfaces;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class OrderItemService: IOrderItemService
    {
        private readonly IOrderItemRepository _repository;
        private readonly IMapper _mapper;

        public OrderItemService(IOrderItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<OrderItem> AddOrderItem(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetAllOrderItem()
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> GetOrderItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderItem(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
