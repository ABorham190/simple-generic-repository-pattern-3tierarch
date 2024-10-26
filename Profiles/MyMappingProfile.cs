using AutoMapper;
using simple_api_generic_repo.DAL.Data.DTOs;
using simple_api_generic_repo.DAL.Data.Entities;

namespace simple_api_generic_repo.Profiles
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile() {

            CreateMap<Employee, EmployeeDTO>()
                  .ReverseMap();
        
        }
    }
}
