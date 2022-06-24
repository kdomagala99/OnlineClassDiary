using AutoMapper;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;

namespace EClassDiary
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Grade, GradeDto>()
                .ForMember(m => m.Subject, c => c.MapFrom(s => s.Subject.Name));
            CreateMap<Subject, SubjectDto>();
            CreateMap<SubjectDto, Subject>();
            CreateMap<Attendance, AttendanceDto>()
                .ForMember(m => m.Status, c => c.MapFrom(s => s.Status.Name))
                .ForMember(m => m.StudentSurname, c => c.MapFrom(s => s.Student.Surname))
                .ForMember(m => m.StudentName, c => c.MapFrom(s => s.Student.Name))
                .ForMember(m => m.TeacherName, c => c.MapFrom(s => s.Teacher.Name))
                .ForMember(m => m.TeacherSurname, c => c.MapFrom(s => s.Teacher.Surname));
        }
    }
}
