using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiBonus.Repositories;

namespace ApiBonus.Controllers
{
    [Route("api/schools")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly ISchoolRepository _schoolRepo;

        public SchoolsController(ISchoolRepository schoolRepo)
        {
            _schoolRepo = schoolRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetSchools()
        {
            try
            {
                var schools = await _schoolRepo.GetSchools();
                return Ok(schools);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
                
        }
    }
}
