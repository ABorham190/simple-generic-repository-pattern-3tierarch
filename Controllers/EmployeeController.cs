using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simple_api_generic_repo.BLL.GenericBase;
using simple_api_generic_repo.BLL.SpecificServicesInterface;
using simple_api_generic_repo.DAL.Data;
using simple_api_generic_repo.DAL.Data.DTOs;
using simple_api_generic_repo.DAL.Data.Entities;
using simple_api_generic_repo.DAL.GenericBase;

namespace simple_api_generic_repo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet("GetByID")]
        public async Task <IActionResult>GetByID(int ID)
        {
            var employee=await _service.GetByID(ID);

            return Ok(employee);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }
       
    }
}
