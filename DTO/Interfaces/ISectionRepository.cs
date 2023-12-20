using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface ISectionRepository
    {
        Task<IEnumerable<SectionEntity>> GetAllSectionAsync();
        Task<SectionEntity> GetaAllSectionByIDAsync(int id);
        Task<SectionEntity> AddSectionAsync(SectionEntity section);
        Task DeleteSectionAsync(int id);
        Task UpdateSectionAsync(SectionEntity section);
    }
}