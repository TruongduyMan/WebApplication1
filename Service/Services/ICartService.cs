using Service.Models;

namespace Service.Services
{
    public interface ICartService
    {
        Task<IEnumerable<Cart>> GetAllCart();
        Task<Cart> GetCartById(int id);
        Task<Cart> AddCart(Cart cart);
        Task UpdateCart(Cart cart);
        Task DeleteCart(int id);

    }
}