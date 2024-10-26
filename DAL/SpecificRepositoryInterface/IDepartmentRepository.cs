﻿using simple_api_generic_repo.DAL.Data.Entities;
using simple_api_generic_repo.DAL.GenericBase;

namespace simple_api_generic_repo.DAL.SpecificRepositoryInterface
{
    public interface IDepartmentRepository:IGenericRepository<Department>
    {
        Task<IEnumerable<Department>> GetAll();
    }
}
