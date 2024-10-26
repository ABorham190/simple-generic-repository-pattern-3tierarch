using AutoMapper;
using simple_api_generic_repo.BLL.GenericBase;
using simple_api_generic_repo.BLL.SpecificServicesInterface;
using simple_api_generic_repo.DAL.Data.Entities;
using simple_api_generic_repo.DAL.GenericBase;
using simple_api_generic_repo.DAL.SpecificRepositoryInterface;

namespace simple_api_generic_repo.BLL.Services
{
    public class DepartmentService : GenericService<Department, Department>,IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        public DepartmentService(IGenericRepository<Department> repository, IMapper mapper,
            IDepartmentRepository departmentRepository) : base(repository, mapper)
        {
            _repository = departmentRepository;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            var departments=await _repository.GetAll();

            return departments;
        }
    }
}
