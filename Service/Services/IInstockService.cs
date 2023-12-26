using Service.ModelsDTO;

namespace Service.Services
{
    public interface IInstockService
    {
        Task<IEnumerable<InstockDTO>> GetAllInstock();
        Task<InstockDTO> GetInstockById(int id);
        Task<InstockDTO> AddInstock(InstockDTO instock);
        Task UpdateInstock(InstockDTO instock);
        Task DeleteInstock(int id);

    }
}