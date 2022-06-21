using AutoMapper;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;

namespace OnlineClassDiaryWebAPI.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Grade, GradeDto>();
            CreateMap<GradeDto, Grade>();
            CreateMap<Subject, SubjectDto>();
            CreateMap<SubjectDto, Subject>();
        }
    }
}

