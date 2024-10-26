using AutoMapper;
using simple_api_generic_repo.BLL.GenericBase;
using simple_api_generic_repo.BLL.SpecificServicesInterface;
using simple_api_generic_repo.DAL.Data.DTOs;
using simple_api_generic_repo.DAL.Data.Entities;
using simple_api_generic_repo.DAL.GenericBase;
using simple_api_generic_repo.DAL.SpecificRepositoryInterface;

namespace simple_api_generic_repo.BLL.Services
{
    public class EmployeeService : GenericService<Employee, EmployeeDTO>,IEmployeeService
    {
        private readonly IEmployeeRepositroy _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IGenericRepository<Employee> repository, IMapper mapper,
            IEmployeeRepositroy employeeRepositroy) : base(repository, mapper)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepositroy;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAll()
        {
            var employees =await _employeeRepository.GetEmployeesAsync();

            return _mapper.Map<IEnumerable<EmployeeDTO>>(employees);
        }
    }
}
