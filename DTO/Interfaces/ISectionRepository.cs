using DataAccessLayer.ModelsEntity;

namespace DataAccessLayer.Interfaces
{
    public interface ISectionRepository
    {
        public List<SectionEntity> GetAllSection();
        public SectionEntity? GetaAllSectionByID(int id);
        public SectionEntity? AddSection(SectionEntity section);
        void DeleteSection(int id);
        void UpdateSection(SectionEntity section);
    }
}