using AutoMapper;
using simple_api_generic_repo.DAL.GenericBase;

namespace simple_api_generic_repo.BLL.GenericBase
{
    public class GenericService<T, TDTO> : IGenericService<T,TDTO> where T : class where TDTO : class
    {
        protected readonly IGenericRepository<T> _repository;
        private readonly IMapper _mapper;
        public GenericService(IGenericRepository<T> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TDTO> GetByID(int ID)
        {
            var result=await _repository.GetByID(ID);

            return _mapper.Map<TDTO>(result);
        }
    }
}
