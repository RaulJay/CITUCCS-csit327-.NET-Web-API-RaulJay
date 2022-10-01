using ApiBonus.Models; 

namespace ApiBonus.Repositories
{
    public interface ISchoolRepository
    {
        public Task<IEnumerable<School>> GetSchools();
    }
}
