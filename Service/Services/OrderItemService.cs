using AutoMapper;
using DataAccessLayer.Interfaces;
using Service.ModelsDTO;
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

        public Task<OrderItemDTO> AddOrderItem(OrderItemDTO orderItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItemDTO>> GetAllOrderItem()
        {
            throw new NotImplementedException();
        }

        public Task<OrderItemDTO> GetOrderItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderItem(OrderItemDTO orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
