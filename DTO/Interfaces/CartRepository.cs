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
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CartRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<CartEntity> AddCartAsync(CartEntity cart)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCartAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CartEntity> GetCartByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CartEntity>> GetCartsAsync()
        {
            return await _dbContext.Carts.ToListAsync();
        }

        public Task UpdateCartAsync(CartEntity cart)
        {
            throw new NotImplementedException();
        }
    }
}
