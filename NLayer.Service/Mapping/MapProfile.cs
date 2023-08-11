using AutoMapper;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.AccountDtos;
using NLayer.Core.DTOs.CLassDayDtos;
using NLayer.Core.DTOs.ClassDtos;
using NLayer.Core.DTOs.CompanyDtos;
using NLayer.Core.DTOs.DayDtos;
using NLayer.Core.DTOs.DepartmentDtos;
using NLayer.Core.DTOs.EmployeesDtos;
using NLayer.Core.DTOs.NoteDtos;
using NLayer.Core.DTOs.PaymentDtos;
using NLayer.Core.DTOs.PollingDtos;
using NLayer.Core.DTOs.ProjectDtos;
using NLayer.Core.DTOs.ProjectEmployeesDto;
using NLayer.Core.DTOs.RoleDtos;
using NLayer.Core.DTOs.StudentDtod;
using NLayer.Core.DTOs.StudentDtos;
using NLayer.Core.DTOs.StudentPollingDtos;
using NLayer.Core.DTOs.TodoListDtos;
using NLayer.Core.DTOs.UserDtos;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Class, ClassDto>().ReverseMap();
            CreateMap<Polling, PollingDto>().ReverseMap();
            CreateMap<Polling, GetByPollingIdWithStudentDto>().ReverseMap();
            CreateMap<Polling, GetWithClassPollingListDto>().ReverseMap();

            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<Payment, GetWithStudentListDto>().ReverseMap();
            CreateMap<Payment, GetByIdWithStudentDto>().ReverseMap();

            CreateMap<Day, DayDto>().ReverseMap();
            CreateMap<ClassDay, ClassDayDto>().ReverseMap();
            CreateMap<AppUser, UserRegisterDto>().ReverseMap();
            CreateMap<AppRole, AppRoleDto>().ReverseMap();
            CreateMap<AppRole, AppRoleListDto>().ReverseMap();
            CreateMap<AppRole, UpdateRoleDto>().ReverseMap();
            CreateMap<AppRole, RoleAssingDto>().ReverseMap();
            CreateMap<AppRole, AppUserRoleDto>();
            CreateMap<string, AppUserRoleDto>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src));

            //Bir entity kütüphanesinin birden fazla Dto"s olması gerekiyorsa Reverse.Map olmasına gerek kalmaz
            //Kullanımıda CreateMap<StudentDto,Student>(); gibi olacaktır

            CreateMap<Student, StudenWithClassDto>().ReverseMap();
            CreateMap<Student, GetWithClassListDto>().ReverseMap();


            CreateMap<Class, ClassWithStudentDto>().ReverseMap();
            CreateMap<StudentPolling, StudentPollingDto>().ReverseMap();
            CreateMap<AppUser, UserListDto>().ReverseMap();
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            CreateMap<AppUser, ResetPasswordDto>().ReverseMap();
            CreateMap<AppUser, UserUpdateDto>().ReverseMap();

            //notes Mapping
            CreateMap<Note, NoteDto>().ReverseMap();
            //TodoList Mapping
            CreateMap<TodoList, TodoListDto>().ReverseMap();

            //company Mapping
            CreateMap<Company, CompanyDto>().ReverseMap();
            //Employees Mapping
            CreateMap<Employees, EmployeesDto>().ReverseMap();

            //deparment Mapping
            CreateMap<Department, DepartmentDto>().ReverseMap();
            //departmwithEmpololyeesList Dto
            CreateMap<Department, GetWithEmployeesDto>().ReverseMap();

            //project dto
            CreateMap<Project, ProjectDto>().ReverseMap();
            //ProjectEmployeesDto
            CreateMap<ProjectEmployees, ProjectEmployeesDto>().ReverseMap();
            CreateMap<Project, GetWithEmployeesListDto>().ReverseMap();

        }
    }
}