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
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CartRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<CartDTO> AddCartAsync(CartDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCartAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CartDTO> GetCartByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CartDTO>> GetCartsAsync()
        {
            return await _dbContext.Carts.ToListAsync();
        }

        public Task UpdateCartAsync(CartDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
