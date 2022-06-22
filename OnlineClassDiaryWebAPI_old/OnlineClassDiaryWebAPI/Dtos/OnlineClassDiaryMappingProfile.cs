using AutoMapper;
using OnlineClassDiaryWebAPI.Entities;

namespace OnlineClassDiaryWebAPI.Dtos
{
    public class OnlineClassDiaryMappingProfile : Profile
    {
        public OnlineClassDiaryMappingProfile()
        {
            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();
            CreateMap<Status, StatusDto>();
            CreateMap<StatusDto, Status>();
            CreateMap<Subject, SubjectDto>();
            CreateMap<SubjectDto, Subject>();
            CreateMap<Semester, SemesterDto>();
            CreateMap<SemesterDto, Semester>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Attendance, AttendanceDto>()
                .ForMember(m => m.Status, c => c.MapFrom(s => s.Status))
                .ForMember(m => m.Teacher, c => c.MapFrom(s => s.Teacher))
                .ForMember(m => m.Student, c => c.MapFrom(s => s.Student));
            CreateMap<AttendanceDto, Attendance>()
                .ForMember(m => m.Status, c => c.MapFrom(s => s.Status))
                .ForMember(m => m.Teacher, c => c.MapFrom(s => s.Teacher))
                .ForMember(m => m.Student, c => c.MapFrom(s => s.Student));
            CreateMap<Class, ClassDto>()
                .ForMember(m => m.Teacher, c => c.MapFrom(s => s.Teacher))
                .ForMember(m => m.Students_List, c => c.MapFrom(s => s.Students_List));
            CreateMap<ClassDto, Class>()
                .ForMember(m => m.Teacher, c => c.MapFrom(s => s.Teacher))
                .ForMember(m => m.Students_List, c => c.MapFrom(s => s.Students_List));
            CreateMap<Grade, GradeDto>()
                .ForMember(m => m.Student, c => c.MapFrom(s => s.Student))
                .ForMember(m => m.Teacher, c => c.MapFrom(s => s.Teacher))
                .ForMember(m => m.Subject, c => c.MapFrom(s => s.Subject))
                .ForMember(m => m.Semester, c => c.MapFrom(s => s.Semester));
            CreateMap<GradeDto, Grade>()
                .ForMember(m => m.Student, c => c.MapFrom(s => s.Student))
                .ForMember(m => m.Teacher, c => c.MapFrom(s => s.Teacher))
                .ForMember(m => m.Subject, c => c.MapFrom(s => s.Subject))
                .ForMember(m => m.Semester, c => c.MapFrom(s => s.Semester));


        }
    }
}
