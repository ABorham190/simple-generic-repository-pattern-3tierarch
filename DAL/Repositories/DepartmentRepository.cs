using Microsoft.EntityFrameworkCore;
using simple_api_generic_repo.DAL.Data;
using simple_api_generic_repo.DAL.Data.Entities;
using simple_api_generic_repo.DAL.GenericBase;
using simple_api_generic_repo.DAL.SpecificRepositoryInterface;

namespace simple_api_generic_repo.DAL.Repositories
{
    public class DepartmentRepository : GenericRepositoryAsync<Department>,IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            var departments =await _context.Departments.ToListAsync();

            return departments;
        }
    }
}
