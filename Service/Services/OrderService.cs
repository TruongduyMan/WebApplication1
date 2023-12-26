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
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<OrderDTO> AddOrder(OrderDTO order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDTO>> GetAllOrder()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDTO> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrder(OrderDTO order)
        {
            throw new NotImplementedException();
        }
    }
}
