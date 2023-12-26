using Service.ModelsDTO;

namespace Service.Services
{
    public interface ICartService
    {
        Task<IEnumerable<CartDTO>> GetAllCart();
        Task<CartDTO> GetCartById(int id);
        Task<CartDTO> AddCart(CartDTO cart);
        Task UpdateCart(CartDTO cart);
        Task DeleteCart(int id);

    }
}