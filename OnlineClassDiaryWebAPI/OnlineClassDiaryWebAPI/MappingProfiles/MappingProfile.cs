using AutoMapper;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;

namespace OnlineClassDiaryWebAPI.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Grade, GradeDto>()
                .ForMember(m => m.Subject, c => c.MapFrom(s => s.Subject.Name));
            CreateMap<Subject, SubjectDto>();
            CreateMap<SubjectDto, Subject>();
        }
    }
}

