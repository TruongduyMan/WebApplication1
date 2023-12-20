using DataAccessLayer.ModelsDTO;

namespace DataAccessLayer.Interfaces
{
    public interface ISectionRepository
    {
        Task<IEnumerable<SectionDTO>> GetAllSectionAsync();
        Task<SectionDTO> GetaAllSectionByIDAsync(int id);
        Task<SectionDTO> AddSectionAsync(SectionDTO section);
        Task DeleteSectionAsync(int id);
        Task UpdateSectionAsync(SectionDTO section);
    }
}