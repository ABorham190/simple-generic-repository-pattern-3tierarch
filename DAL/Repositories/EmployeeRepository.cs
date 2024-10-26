using simple_api_generic_repo.DAL.GenericBase;
using simple_api_generic_repo.DAL.Data.Entities;
using simple_api_generic_repo.DAL.SpecificRepositoryInterface;
using simple_api_generic_repo.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace simple_api_generic_repo.DAL.Repositories
{
    public class EmployeeRepository : GenericRepositoryAsync<Employee>, IEmployeeRepositroy
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
