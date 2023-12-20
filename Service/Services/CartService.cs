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
    public class CartService: ICartService
    {
        private readonly ICartRepository _repository;
        private readonly IMapper _mapper;

        public CartService(ICartRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<Cart> AddCart(Cart cart)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCart(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cart>> GetAllCart()
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetCartById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCart(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
