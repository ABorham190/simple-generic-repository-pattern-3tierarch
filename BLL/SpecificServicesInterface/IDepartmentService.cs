using simple_api_generic_repo.BLL.GenericBase;
using simple_api_generic_repo.DAL.Data.Entities;

namespace simple_api_generic_repo.BLL.SpecificServicesInterface
{
    public interface IDepartmentService:IGenericService<Department,Department>
    {
        Task<IEnumerable<Department>> GetAll();
    }
}
