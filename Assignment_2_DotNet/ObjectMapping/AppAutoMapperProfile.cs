using Assignment_2_DotNet.Entities.Dtos;
using Assignment_2_DotNet.Entities.Models;
using AutoMapper;

namespace Assignment_2_DotNet.ObjectMapping
{
    public class AppAutoMapperProfile : Profile
    {
        public AppAutoMapperProfile()
        {
            CreateMap<EmployeeDto, Employee>();
            CreateMap<DepartmentDto, Department>();
        }
    }
}
