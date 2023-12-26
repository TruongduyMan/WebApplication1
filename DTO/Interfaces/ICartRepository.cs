using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface ICartRepository
    {
        public List<CartEntity> GetCarts();
        public CartEntity? GetCartById(int id);
        public CartEntity? AddCart(CartEntity cart);
        void DeleteCart(int id);
        void UpdateCart(CartEntity cart);
    }
}
