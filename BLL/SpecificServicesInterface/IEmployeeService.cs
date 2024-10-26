using simple_api_generic_repo.BLL.GenericBase;
using simple_api_generic_repo.DAL.Data.DTOs;
using simple_api_generic_repo.DAL.Data.Entities;

namespace simple_api_generic_repo.BLL.SpecificServicesInterface
{
    public interface IEmployeeService:IGenericService<Employee,EmployeeDTO>
    {
        Task<IEnumerable<EmployeeDTO>> GetAll();
    }
}
