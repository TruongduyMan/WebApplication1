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

        public CartEntity AddCart(CartEntity cart)
        {
            _dbContext.Carts.Add(cart);
            _dbContext.SaveChanges();
            return cart;
        }

        public void DeleteCart(int id)
        {
            var cart = _dbContext.Carts.FirstOrDefault(c => c.ID == id);
            if(cart != null) { 
                _dbContext.Carts.Remove(cart);
                _dbContext.SaveChanges();
            }
        }

        public CartEntity? GetCartById(int id)
        {
            return _dbContext.Carts.FirstOrDefault(c => c.ID == id);   
        }

        public List<CartEntity> GetCarts()
        {
            return _dbContext.Carts.ToList();
        }

        public void UpdateCart(CartEntity cart)
        {
            _dbContext.Carts.Add(cart);
        }
    }
}
