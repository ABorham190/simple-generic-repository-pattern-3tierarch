using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simple_api_generic_repo.DAL.SpecificRepositoryInterface;

namespace simple_api_generic_repo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _departmentRepository.GetAll());
        }

        [HttpGet("GetByID")]
        public async Task<IActionResult>GetByID(int ID)
        {
            var department=await _departmentRepository.GetByID(ID);

            return Ok(department);
        }
    }
}
