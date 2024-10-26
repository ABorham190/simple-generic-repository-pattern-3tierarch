namespace simple_api_generic_repo.BLL.GenericBase
{
    public interface IGenericService<T,TDTO>where TDTO : class
    {
        Task<TDTO> GetByID(int ID);
    }
}
