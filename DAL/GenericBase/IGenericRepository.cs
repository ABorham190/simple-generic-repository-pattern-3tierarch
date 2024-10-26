namespace simple_api_generic_repo.DAL.GenericBase
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?>GetByID(int id);
    }
}
