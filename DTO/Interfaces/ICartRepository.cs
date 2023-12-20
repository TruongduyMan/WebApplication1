using DataAccessLayer.ModelsDTO;

namespace DataAccessLayer.Interfaces
{
    public interface ICartRepository
    {
        Task<IEnumerable<CartDTO>> GetCartsAsync();
        Task<CartDTO> GetCartByIdAsync(int id);
        Task<CartDTO> AddCartAsync(CartDTO cart);
        Task DeleteCartAsync(int id);
        Task UpdateCartAsync(CartDTO cart);
    }
}
