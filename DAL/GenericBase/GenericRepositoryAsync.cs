using Microsoft.EntityFrameworkCore;
using simple_api_generic_repo.DAL.Data;

namespace simple_api_generic_repo.DAL.GenericBase
{
    public class GenericRepositoryAsync<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbset;
        public GenericRepositoryAsync(AppDbContext context)
        {
            _context = context;
            _dbset=_context.Set<T>();
        }
        public async Task<T?> GetByID(int id)
        {
            var result=await _dbset.FindAsync(id);
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
