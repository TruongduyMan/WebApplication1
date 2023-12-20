using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface ICartRepository
    {
        Task<IEnumerable<CartEntity>> GetCartsAsync();
        Task<CartEntity> GetCartByIdAsync(int id);
        Task<CartEntity> AddCartAsync(CartEntity cart);
        Task DeleteCartAsync(int id);
        Task UpdateCartAsync(CartEntity cart);
    }
}
