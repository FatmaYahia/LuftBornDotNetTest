using AutoMapper;
using Entity.AppModel;
using Entity.AuthModel;
using LuftbornTest.AppAdmin.ViewModel;
using System.Numerics;

namespace LuftbornTest.AppAdmin.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Department, DepartmentVM>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
           
            CreateMap<DepartmentVM, Department>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.Employees, opt => opt.Ignore());
            CreateMap<Employee, EmployeeVM>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            

            CreateMap<EmployeeVM, Employee>()
               .ForMember(dest => dest.Id, opt => opt.Ignore())
               .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
               .ForMember(dest => dest.Gender, opt => opt.Ignore())
               .ForMember(dest => dest.Department, opt => opt.Ignore())

               ;

        }
    }
}
