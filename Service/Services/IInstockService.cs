using Service.Models;

namespace Service.Services
{
    public interface IInstockService
    {
        Task<IEnumerable<Instock>> GetAllInstock();
        Task<Instock> GetInstockById(int id);
        Task<Instock> AddInstock(Instock instock);
        Task UpdateInstock(Instock instock);
        Task DeleteInstock(int id);

    }
}