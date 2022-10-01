using ApiBonus.Models;
using ApiBonus.Context;
using Dapper;

namespace ApiBonus.Repositories
{
    public class SchoolRepository: ISchoolRepository
    {
        private readonly DapperContext _context;

        public SchoolRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<School>> GetSchools()
        {
            //throw new NotImplementedException();
            var sql = "SELECT * FROM School";
            using (var connection = _context.CreateConnection())
            {
                var school = await connection.QueryAsync<School>(sql);

                return school.ToList();
            }
        }
    }
}
